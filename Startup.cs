using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PersonsInfoV2Api.BussinessLogic;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;
using IdentityServer4;
using IdentityServer4.Models;


using PersonsInfoV2Api.Filters;

namespace PersonsInfoV2Api
{
    public class Startup
    {
        //public IConfiguration Configuration { get; }

        //public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment env, IConfiguration configuration)
        //{
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(env.ContentRootPath)
        //        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        //    Configuration = builder.Build();
        //    Configuration = configuration;
        //}
        //public Startup(IConfiguration configuration)
        //{

        //}

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        //public void ConfigureServices(IServiceCollection services)
        //{

        //}



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            var data = Configuration["Key"];
            var data2 = Configuration.GetValue<string>("Key");

            var User = Configuration.GetSection("HangfireSettings:UserName").Value;
            var Pass = Configuration.GetSection("HangfireSettings:Password").Value;


            var key = "This is my first Test Key";

            //services.AddControllers();


            // var optionsBuilder = new DbContextOptionsBuilder<PersonsInfoV3NewContext>();
            //  var data = Configuration.GetConnectionString("PersonsInfo1Connection");
            //optionsBuilder.UseSqlServer(Configuration.GetConnectionString("PersonsInfo1Connection"));

            services.AddDbContext<PersonsInfoV3NewContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("PersonsInfo1Connection")));



            #region Identity Server4

            //    services.AddIdentityServer()
            //.AddDeveloperSigningCredential()
            //.AddInMemoryClients(Clients.Get())
            //.AddInMemoryApiResources(ApiResources.Get())
            //.AddInMemoryIdentityResources(IdentityResources.Get())
            //.AddInMemoryApiScopes(ApiScopes.Get());

            //    services.AddAuthentication(options =>
            //    {
            //        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            //    })
            //    .AddIdentityServerAuthentication(options =>
            //    {
            //        options.Authority = "https://localhost:5001";
            //        options.RequireHttpsMetadata = false;
            //        options.ApiName = "api1";
            //    });

            #endregion


            services.AddControllers().AddJsonOptions(o =>
            {
                o.JsonSerializerOptions.PropertyNamingPolicy = null;
                //   o.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
            });

            services.AddLogging(builder =>
            {
                builder.AddConsole();  // Add Console logger
                builder.AddDebug();    // Add Debug logger
            });
            services.AddControllers(options =>
            {
                options.Filters.Add<GlobalExceptionFilter>();
            });


            services.AddControllers().AddJsonOptions(o => { o.JsonSerializerOptions.PropertyNamingPolicy = null; });
            services.AddCors(options => options.AddDefaultPolicy(b => b.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));



            // var key = "This is my first Test Key";
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key))
                };
            });

            #region Dependency Injection
            services.AddScoped<IJwtAuth>(provider =>
            {
                var context = provider.GetRequiredService<PersonsInfoV3NewContext>();
                return new Auth(context, key);
            });



            //services.AddControllers(options =>
            //{
            //    options.Filters.Add<GlobalExceptionFilter>();
            //});

            services.AddTransient<PersonsInfoV3NewContext, PersonsInfoV3NewContext>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserBussinessLogic, UserBussinessLogic>();

            services.AddScoped<IUserContactRepo, UserContactRepo>();
            services.AddScoped<IUserContactBussinessLogic, UserContactBussinessLogic>();

            services.AddScoped<IUserEmailRepo, UserEmailRepo>();
            services.AddScoped<IUserEmailBussinessLogic, UserEmailBussinessLogic>();

            services.AddScoped<ICountryRepo, CountryRepo>();
            services.AddScoped<ICountryBussinessLogic, CountryBussinessLogic>();

            services.AddScoped<IStateRepo, StateRepo>();
            services.AddScoped<IStateBussinessLogic, StateBussinessLogic>();

            services.AddScoped<ISkillRepo, SkillRepo>();
            services.AddScoped<ISkillBussinessLogic, SkillBussinessLogic>();

            services.AddScoped<IGenderRepo, GenderRepo>();
            services.AddScoped<IGenderBussinessLogic, GenderBussinessLogic>();

            services.AddScoped<IInstitutionRepository, InstitutionRepository>();
            services.AddScoped<IInstitutionBussinessLogic, InstitutionBussinessLogic>();


            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyBussinessLogic, CompanyBussinessLogic>();


            services.AddScoped<IInstitutionEmailRepository, InstitutionEmailRepository>();
            services.AddScoped<IInstitutionEmailBussinessLogic, InstitutionEmailBussinessLogic>();

            services.AddScoped<IInstitutionContactRepository, InstitutionContactRepository>();
            services.AddScoped<IInstitutionContactBussinessLogic, InstitutionContactBussinessLogic>();

            services.AddScoped<ICompanyEmailRepository, CompanyEmailRepository>();
            services.AddScoped<ICompanyEmailBussinessLogic, CompanyEmailBussinessLogic>();

            services.AddScoped<ICompanyContactRepository, CompanyContactRepo>();
            services.AddScoped<ICompanyContactBussinessLogic, CompanyContactBussinessLogic>();

            services.AddScoped<ICompanyAddressRepository, CompanyAddressRepo>();
            services.AddScoped<ICompanyAddressBussinessLogic, CompanyAddressBussinessLogic>();

            services.AddScoped<ICoutryStateRepo, CoutryStateRepository>();
            services.AddScoped<ICoutryStateBusinessLogic, CoutryStateBusinessLogic>();

            services.AddScoped<IDesignationRepo, DesignationRepository>();
            services.AddScoped<IDesignationBusinessLogic, DesignationBusinessLogic>();

            services.AddScoped<IFamilyRepo, FamilyRepository>();
            services.AddScoped<IFamilyBusinessLogic, FamilyBusinessLogic>();

            services.AddScoped<IFamilyContactRepo, FamilyContactRepository>();
            services.AddScoped<IFamilyContactBusinessLogic, FamilyContactBusinessLogic>();



            services.AddScoped<IFamilyEducationDetailRepository, FamilyEducationDetailRepository>();
            services.AddScoped<IFamilyEducationDetailBusinessLogic, FamilyEducationDetailBusinessLogic>();


            services.AddScoped<IFamilyEmailRepo, FamilyEmailRepo>();
            services.AddScoped<IFamilyEmailbusinessLogic, FamilyEmailbusinessLogic>();

            services.AddScoped<IInstitutionAddressRepository, InstitutionAddressRepository>();
            services.AddScoped<IInstitutionAddressBusinessLogic, InstitutionAddressBusinessLogic>();


            services.AddScoped<IMarritalStatusRepo, MarritalStatusRepo>();
            services.AddScoped<IMarritalStatusBussinessLogic, MarritalStatusBussinessLogic>();

            services.AddScoped<IMediumRepo, MediumRepo>();
            services.AddScoped<IMediumBussinessLogic, MediumBussinessLogic>();

            services.AddScoped<IQualificationTypeRepo, QualificationTyperepo>();
            services.AddScoped<IQualificationtypeBussinessLogic, QualificationtypeBussinessLogic>();

            services.AddScoped<IRelationTypeRepo, RelationTypeRepository>();
            services.AddScoped<IRelationTypeBusinessLogic, RelationTypeBusinessLogic>();

            services.AddScoped<IUserAddressDetailRepository, UserAddressDetailRepository>();
            services.AddScoped<IUserAddressDetailBusinessLogic, UserAddressDetailBusinessLogic>();

            services.AddScoped<IUserSkillRepo, UserSkillRepository>();
            services.AddScoped<IUserSkillBusinessLogic, UserSkillBusinessLogic>();

            services.AddScoped<IUserCompanyRepo, UserCompanyRepository>();
            services.AddScoped<IUserCompanyBusinessLogic, UserCompanyBusinessLogic>();

            services.AddScoped<IUserEducationDetailRepo, UserEducationDetailRepo>();
            services.AddScoped<IUserEducationDetailsBussinessLogic, UserEducationDetailBusinessLogics>();

            services.AddTransient<ICourseRepo, CourseRepoRepository>();
            services.AddTransient<ICourseBusinessLogic, CourseBusinessLogic>();

            services.AddScoped<ICourseYearRepo, CourseYearRepository>();
            services.AddScoped<ICourseYearBusinessLogic, CourseYearBusinessLogic>();

            services.AddScoped<ICyearRepo, CyearRepository>();
            services.AddScoped<ICyearBusinessLogic, CyearBusinessLogic>();

            services.AddScoped<IInstitutionCourseRepository, InstitutionCourseRepository>();
            services.AddScoped<IInstitutionCourseBusinessLogic, InstitutionCourseBusinessLogic>();

            services.AddScoped<IRepoSemester, SemesterRepository>();
            services.AddScoped<ISemesterBusinessLogic, SemesterBusinessLogic>();

            services.AddScoped<IRepoUserData, RepoUserData1>();
            services.AddScoped<IbussiUserData, UserDataBussinessLogic>();

            services.AddScoped<IRepoYearSemester, YearSemesterRepository>();
            services.AddScoped<IYearSemesterBusinessLogic, YearSemesterBusinessLogic>();

            services.AddScoped<IRepoUserCourse, UserCourseRepository>();
            services.AddScoped<IUserCourseBusinessLogic, UserCourseBusinessLogic>();

            services.AddScoped<IDepartmentRepo, DepartmentRepository>();
            services.AddScoped<IDepartmentBusinessLogic, DepartmentBusinessLogic>();

            services.AddScoped<IEmploymentTypeRepo, EmploymentTypeRepository>();
            services.AddScoped<IEmploymentTypeBusinessLogic, EmploymentTypeBusinessLogic>();

            services.AddScoped<IIndustryTypeRepository, IndustryTypeRepository>();
            services.AddScoped<IIndustryTypeBusinessLogic, IndustryTypeBusinessLogic>();

            services.AddScoped<IReviewRepo, ReviewRepository>();
            services.AddScoped<IReviewBusinessLogic, ReviewBusinessLogic>();

            services.AddScoped<IRoleRepo, RoleRepository>();
            services.AddScoped<IRoleBusinessLogic, RoleBusinessLogic>();

            services.AddScoped<IRoleCategoryRepo, RoleCategoryRepository>();
            services.AddScoped<IRoleCategoryBusinessLogic, RoleCategoryBusinessLogic>();

            services.AddScoped<ITemplateRepo, TemplateRepository>();
            services.AddScoped<ITemplateBusinessLogic, TemplateBusinessLogic>();

            services.AddScoped<ITemplateTypeRepo, TemplateTypeRepository>();
            services.AddScoped<ITemplateTypeBusinessLogic, TemplateTypeBusinessLogic>();

            services.AddScoped<IVacanciesSkillRepo, VacanciesSkillRepository>();
            services.AddScoped<IVacanciesSkillBusinessLogic, VacanciesSkillBusinessLogic>();

            services.AddScoped<IVacancyRepo, VacancyRepository>();
            services.AddScoped<IVacancyBusinessLogic, VacancyBusinessLogic>();

            services.AddScoped<ICompanyReviewRepository, CompanyReviewRepository>();
            services.AddScoped<ICompanyReviewBusinessLogic, CompanyReviewBusinessLogic>();

            services.AddScoped<IMenuRepo, MenuRepository>();
            services.AddScoped<IMenuBusinessLogic, MenuBusinessLogic>();

            services.AddScoped<IContactTypeRepo, ContactTypeRepository>();
            services.AddScoped<IContactTypeBusinessLogic, ContactTypeBusinessLogic>();

            services.AddScoped<IStatusRepo, StatusRepository>();
            services.AddScoped<IStatusBusinessLogic, StatusBusinessLogic>();

            services.AddScoped<IMenuListRepo, MenuListRepository>();
            services.AddScoped<IMenuListBusinessLogic, MenuListBusinessLogic>();

            services.AddScoped<ISprintRepo, SprintRepository>();
            services.AddScoped<ISprintBusinessLogic, SprintBusinessLogic>();

            services.AddScoped<ISprintTaskRepo, SprintTaskRepository>();
            services.AddScoped<ISprintTaskBusinessLogic, SprintTaskBusinessLogic>();

            services.AddScoped<ITaskCommentRepo, TaskCommentRepository>();
            services.AddScoped<ITaskCommentBusinessLogic, TaskCommentBusinessLogic>();

            services.AddScoped<ITaskCommentDocumentRepo, TaskCommentDocumentRepository>();
            services.AddScoped<ITaskCommentDocumentBusinessLogic, TaskCommentDocumentBusinessLogic>();

            services.AddScoped<ITaskDocumentRepo, TaskDocumentRepository>();
            services.AddScoped<ITaskDocumentBusinessLogic, TaskDocumentBusinessLogic>();

            services.AddScoped<ITaskLogRepo, TaskLogRepository>();
            services.AddScoped<ITaskLogBusinessLogic, TaskLogBusinessLogic>();

            services.AddScoped<ITaskStateRepo, TaskStateRepository>();
            services.AddScoped<ITaskStateBusinessLogic, TaskStateBusinessLogic>();

            services.AddScoped<IUserTypeRepo, UserTypeRepository>();
            services.AddScoped<IUserTypeBusinessLogic, UserTypeBusinessLogic>();

            services.AddScoped<IStoryRepo, StoryRepository>();
            services.AddScoped<IStoryBusinessLogic, StoryBusinessLogic>();

            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddScoped<ICategoryBussinessLogic, CategoryBussinessLogic>();

            services.AddScoped<ILookUpRepo, LookUpRepo>();
            services.AddScoped<ILookUpBussinessLogic, LookUpBussinessLogic>();

            services.AddScoped<ILookUpValueRepo, LookUpValueRepo>();
            services.AddScoped<ILookUpValueBussinessLogic, LookUpValueBussinessLogic>();


            services.AddScoped<IReferralRepo, ReferralRepo>();
            services.AddScoped<IReferralBussinessLogic, ReferralsBussinessLogic>();


            //services.AddScoped<IQuestionRepo, QuestionRepo>();
            //services.AddScoped<IQuestionBussinessLogic, QuestionBussinessLogic>();

            services.AddScoped<IQuestionCategoryRepo, QuestionCategoryRepo>();
            services.AddScoped<IQuestionCategoryBussinessLogic, QuestionCategoryBussinessLogic>();

            services.AddScoped<IJobRepo, JobRepository>();
            services.AddScoped<IJobBusinessLogic, JobBusinessLogic>();

            services.AddScoped<ILocationRepo, LocationRepository>();
            services.AddScoped<ILocationBusinessLogic, LocationBusinessLogic>();

            services.AddScoped<IAdAttendanceRepository, AdAttendanceRepository>();
            services.AddScoped<IAdAttendanceBusinessLogic, AdAttendanceBusinessLogic>();

            services.AddScoped<IAdattendanceApprovalRepository, AdattendanceApprovalRepository>();
            services.AddScoped<IAdattendanceApprovalBusinessLogic, AdattendanceApprovalBusinessLogic>();


            #endregion
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder => builder.WithOrigins("http://localhost:4200")
                                      .AllowAnyMethod()
                                      .AllowAnyHeader());
            });

            //services.AddSession(options =>
            //{
            //    options.IdleTimeout = TimeSpan.FromSeconds(30);
            //    options.Cookie.HttpOnly = true;
            //    options.Cookie.IsEssential = true;
            //});

            //services.AddMvc().AddSessionStateTempDataProvider();
            // services.AddSession();

            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });



            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PersonsInfoV2Api", Version = "v1" });
            });
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PersonsInfoV2Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseSession();

            app.UseRouting();

            app.UseCors(c => c.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseAuthentication();

            app.UseAuthorization();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }



    }

    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
    {
        new Client
        {
            ClientId = "client_id", // Unique identifier for the client application
            ClientName = "Sample Client", // Human-readable name for the client
            Description = "This is a sample client for demonstration purposes.", // Optional description
            AllowedGrantTypes = GrantTypes.Code, // Defines the allowed OAuth2 flows for the client
            RequireClientSecret = true, // Specifies whether the client must send a secret to authenticate
            ClientSecrets =
            {
                new Secret("client_secret".Sha256()) // Secret used for client authentication (hashed for security)
            },
            RedirectUris =
            {
                "https://localhost:5001/signin-oidc" // List of URIs that the client can redirect to after successful login
            },
            PostLogoutRedirectUris =
            {
                "https://localhost:5001/signout-callback-oidc" // List of URIs that the client can redirect to after logout
            },
            AllowedScopes = new List<string>
            {
                IdentityServerConstants.StandardScopes.OpenId, // Allows OIDC (OpenID Connect)
                IdentityServerConstants.StandardScopes.Profile, // Allows profile information such as name and email
                "api1" // Custom API scope that the client can access
            },
            RequirePkce = true, // Enforces Proof Key for Code Exchange (PKCE) for added security
            AllowOfflineAccess = true, // Allows requesting refresh tokens
            AccessTokenLifetime = 3600, // Lifetime of the access token in seconds (1 hour)
            AbsoluteRefreshTokenLifetime = 2592000, // Lifetime of the refresh token (30 days)
            RefreshTokenUsage = TokenUsage.ReUse, // Specifies if the same refresh token can be reused or must be rotated
            RefreshTokenExpiration = TokenExpiration.Sliding, // Refresh token expiration policy
            AlwaysIncludeUserClaimsInIdToken = true, // Forces user claims to be included in the ID token
            RequireConsent = false, // Skips the consent screen for trusted clients
            AllowAccessTokensViaBrowser = true, // Allows the access token to be returned via the browser (for implicit flow)
            AllowedCorsOrigins =
            {
                "https://localhost:5001" // CORS allowed origins to enable cross-origin requests
            },
            EnableLocalLogin = true, // Allows logging in with local accounts (username/password)
            IdentityTokenLifetime = 300, // Lifetime of the identity token (5 minutes)
            SlidingRefreshTokenLifetime = 1296000, // Sliding expiration for refresh tokens (15 days)
            BackChannelLogoutUri = "https://localhost:5001/logout-callback", // URI to notify on back-channel logout
            FrontChannelLogoutUri = "https://localhost:5001/logout-frontend" // URI to notify on front-channel logout
        }
    };
        }

    }

    public static class ApiScopes
    {
        public static IEnumerable<ApiScope> Get()
        {
            return new List<ApiScope>
        {
            new ApiScope("api1", "My API")
        };
        }
    }

    //    public static class IdentityResources
    //    {
    //        public static IEnumerable<IdentityResource> Get()
    //        {
    //            return new List<IdentityResource>
    //        {
    //            new IdentityResource.OpenId(),
    //            new IdentityResource.Profile()
    //        };
    //        }
    //    }
}
