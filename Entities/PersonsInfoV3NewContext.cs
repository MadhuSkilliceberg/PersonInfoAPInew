using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class PersonsInfoV3NewContext : DbContext
    {
        public PersonsInfoV3NewContext()
        {
        }

        public PersonsInfoV3NewContext(DbContextOptions<PersonsInfoV3NewContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adattendance> Adattendances { get; set; }
        public virtual DbSet<AdattendanceApproval> AdattendanceApprovals { get; set; }
        public virtual DbSet<Adholiday> Adholidays { get; set; }
        public virtual DbSet<AdleaveBalance> AdleaveBalances { get; set; }
        public virtual DbSet<AdleaveRequest> AdleaveRequests { get; set; }
        public virtual DbSet<AdleaveType> AdleaveTypes { get; set; }
        public virtual DbSet<BookDemo> BookDemos { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Chat> Chats { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CommentDocument> CommentDocuments { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyAddress> CompanyAddresses { get; set; }
        public virtual DbSet<CompanyBenefit> CompanyBenefits { get; set; }
        public virtual DbSet<CompanyContact> CompanyContacts { get; set; }
        public virtual DbSet<CompanyEmail> CompanyEmails { get; set; }
        public virtual DbSet<CompanyJob> CompanyJobs { get; set; }
        public virtual DbSet<CompanyJobType> CompanyJobTypes { get; set; }
        public virtual DbSet<CompanyReview> CompanyReviews { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseBranch> CourseBranches { get; set; }
        public virtual DbSet<CourseYear> CourseYears { get; set; }
        public virtual DbSet<CoutryState> CoutryStates { get; set; }
        public virtual DbSet<Cyear> Cyears { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Department1> Departments1 { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<EmployeeCount> EmployeeCounts { get; set; }
        public virtual DbSet<EmploymentType> EmploymentTypes { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Family> Families { get; set; }
        public virtual DbSet<FamilyContact> FamilyContacts { get; set; }
        public virtual DbSet<FamilyEducationDetail> FamilyEducationDetails { get; set; }
        public virtual DbSet<FamilyEmail> FamilyEmails { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<IndustryType> IndustryTypes { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<InstitutionAddress> InstitutionAddresses { get; set; }
        public virtual DbSet<InstitutionContact> InstitutionContacts { get; set; }
        public virtual DbSet<InstitutionCourse> InstitutionCourses { get; set; }
        public virtual DbSet<InstitutionEmail> InstitutionEmails { get; set; }
        public virtual DbSet<InstitutionJob> InstitutionJobs { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobJobType> JobJobTypes { get; set; }
        public virtual DbSet<JobSchedule> JobSchedules { get; set; }
        public virtual DbSet<JobSupplementalPay> JobSupplementalPays { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LookUp> LookUps { get; set; }
        public virtual DbSet<LookUpValue> LookUpValues { get; set; }
        public virtual DbSet<MarritalStatus> MarritalStatuses { get; set; }
        public virtual DbSet<Medium> Media { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuList> MenuLists { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionCategory> QuestionCategories { get; set; }
        public virtual DbSet<QuestionOption> QuestionOptions { get; set; }
        public virtual DbSet<QuestionType> QuestionTypes { get; set; }
        public virtual DbSet<QulificationType> QulificationTypes { get; set; }
        public virtual DbSet<Referral> Referrals { get; set; }
        public virtual DbSet<RelationType> RelationTypes { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<ReviewsComment> ReviewsComments { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleCategory> RoleCategories { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<Sprint> Sprints { get; set; }
        public virtual DbSet<SprintTask> SprintTasks { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskComment> TaskComments { get; set; }
        public virtual DbSet<TaskCommentDocument> TaskCommentDocuments { get; set; }
        public virtual DbSet<TaskDocument> TaskDocuments { get; set; }
        public virtual DbSet<TaskLog> TaskLogs { get; set; }
        public virtual DbSet<TaskState> TaskStates { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<TemplateType> TemplateTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAddressDetail> UserAddressDetails { get; set; }
        public virtual DbSet<UserCompany> UserCompanies { get; set; }
        public virtual DbSet<UserContact> UserContacts { get; set; }
        public virtual DbSet<UserCourse> UserCourses { get; set; }
        public virtual DbSet<UserEducationDetail> UserEducationDetails { get; set; }
        public virtual DbSet<UserEmail> UserEmails { get; set; }
        public virtual DbSet<UserExam> UserExams { get; set; }
        public virtual DbSet<UserExamQuestion> UserExamQuestions { get; set; }
        public virtual DbSet<UserExamQuestionsAudit> UserExamQuestionsAudits { get; set; }
        public virtual DbSet<UserProfileQuestion> UserProfileQuestions { get; set; }
        public virtual DbSet<UserSkill> UserSkills { get; set; }
        public virtual DbSet<UserTokenSession> UserTokenSessions { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<VacanciesSkill> VacanciesSkills { get; set; }
        public virtual DbSet<Vacancy> Vacancies { get; set; }
        public virtual DbSet<YearSemester> YearSemesters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=RAAZ2024\\SQLEXPRESS;Database=PersonsInfoV3New;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Adattendance>(entity =>
            {
                entity.HasKey(e => e.AttendanceId)
                    .HasName("PK__ADAttend__8B69261CB055ABB2");

                entity.ToTable("ADAttendance");

                entity.Property(e => e.AttendanceDate).HasColumnType("date");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HoursWorked).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.OvertimeHours)
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Adattendances)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Attendance_User");
            });

            modelBuilder.Entity<AdattendanceApproval>(entity =>
            {
                entity.HasKey(e => e.AttendanceApprovalId)
                    .HasName("PK__ADAttend__F2E0C95DD45198A1");

                entity.ToTable("ADAttendanceApproval");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AdattendanceApprovals)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AttendanceApproval_User");
            });

            modelBuilder.Entity<Adholiday>(entity =>
            {
                entity.HasKey(e => e.HolidayId)
                    .HasName("PK__ADHolida__2D35D57AB64B87C4");

                entity.ToTable("ADHoliday");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.HolidayDate).HasColumnType("date");

                entity.Property(e => e.HolidayName).HasMaxLength(100);

                entity.Property(e => e.IsMandatory).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AdleaveBalance>(entity =>
            {
                entity.HasKey(e => e.LeaveBalanceId)
                    .HasName("PK__ADLeaveB__8A68C4A24E48E50B");

                entity.ToTable("ADLeaveBalance");

                entity.Property(e => e.AdleaveBalance1)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("ADLeaveBalance");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.AdleaveBalances)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .HasConstraintName("FK_LeaveBalance_LeaveType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AdleaveBalances)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_LeaveBalance_User");
            });

            modelBuilder.Entity<AdleaveRequest>(entity =>
            {
                entity.HasKey(e => e.LeaveRequestId)
                    .HasName("PK__ADLeaveR__609421EE6259E057");

                entity.ToTable("ADLeaveRequest");

                entity.Property(e => e.AppliedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.ReviewedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.AdleaveRequests)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .HasConstraintName("FK_LeaveRequest_LeaveType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AdleaveRequests)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_LeaveRequest_User");
            });

            modelBuilder.Entity<AdleaveType>(entity =>
            {
                entity.HasKey(e => e.LeaveTypeId)
                    .HasName("PK__ADLeaveT__43BE8F14497272A5");

                entity.ToTable("ADLeaveType");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LeaveTypeName).HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<BookDemo>(entity =>
            {
                entity.ToTable("BookDemo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.EducationQualification)
                    .WithMany(p => p.BookDemos)
                    .HasForeignKey(d => d.EducationQualificationId)
                    .HasConstraintName("FK__BookDemo__Educat__719CDDE7");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.BookDemos)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__BookDemo__StateI__72910220");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.ParentCategory)
                    .WithMany(p => p.InverseParentCategory)
                    .HasForeignKey(d => d.ParentCategoryId)
                    .HasConstraintName("FK__Categorie__Paren__73852659");
            });

            modelBuilder.Entity<Chat>(entity =>
            {
                entity.ToTable("Chat");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Heading).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Chats)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK__Chat__GroupId__74794A92");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__Chat__ParentId__756D6ECB");

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.Chats)
                    .HasForeignKey(d => d.ToUserId)
                    .HasConstraintName("FK__Chat__ToUserId__76619304");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Heading)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CommentDocument>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.CommentDocuments)
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("FK_CommentDocuments_CommentId");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.CommentDocuments)
                    .HasForeignKey(d => d.DocumentId)
                    .HasConstraintName("FK_CommentDocuments_DocumentId");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CompanyAddress>(entity =>
            {
                entity.ToTable("CompanyAddress");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FlotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyAddresses)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__CompanyAd__Compa__793DFFAF");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CompanyAddresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__CompanyAd__Count__7A3223E8");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.CompanyAddresses)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__CompanyAd__State__7B264821");
            });

            modelBuilder.Entity<CompanyBenefit>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Benefit)
                    .WithMany(p => p.CompanyBenefits)
                    .HasForeignKey(d => d.BenefitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyBenefits_BenefitId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyBenefits)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyBenefits_CompanyId");
            });

            modelBuilder.Entity<CompanyContact>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.CompanyContacts)
                    .HasForeignKey(d => d.ContactTypeId)
                    .HasConstraintName("FK__CompanyCo__Conta__7E02B4CC");
            });

            modelBuilder.Entity<CompanyEmail>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.CompanyEmails)
                    .HasForeignKey(d => d.ContactTypeId)
                    .HasConstraintName("FK__CompanyEm__Conta__7EF6D905");
            });

            modelBuilder.Entity<CompanyJob>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyJobs)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyJobs_CompanyId");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.CompanyJobs)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyJobs_JobId");
            });

            modelBuilder.Entity<CompanyJobType>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyJobTypes)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyJobTypes_CompanyId");

                entity.HasOne(d => d.JobType)
                    .WithMany(p => p.CompanyJobTypes)
                    .HasForeignKey(d => d.JobTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyJobTypes_JobTypeId");
            });

            modelBuilder.Entity<CompanyReview>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyReviews)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyReviews");

                entity.HasOne(d => d.Review)
                    .WithMany(p => p.CompanyReviews)
                    .HasForeignKey(d => d.ReviewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyReviews_Review");
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.ToTable("ContactType");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CourseBranch>(entity =>
            {
                entity.ToTable("CourseBranch");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CourseYear>(entity =>
            {
                entity.ToTable("CourseYear");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CyearsId).HasColumnName("CYearsId");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseYears)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__CourseYea__Cours__05A3D694");

                entity.HasOne(d => d.Cyears)
                    .WithMany(p => p.CourseYears)
                    .HasForeignKey(d => d.CyearsId)
                    .HasConstraintName("FK__CourseYea__CYear__0697FACD");
            });

            modelBuilder.Entity<CoutryState>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CoutryStates)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__CoutrySta__Count__078C1F06");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.CoutryStates)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__CoutrySta__State__0880433F");
            });

            modelBuilder.Entity<Cyear>(entity =>
            {
                entity.ToTable("CYears");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Department1>(entity =>
            {
                entity.ToTable("Departments");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.ToTable("Designation");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.File).IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.FileType).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.ToTable("Education");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeCount>(entity =>
            {
                entity.ToTable("EmployeeCount");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmploymentType>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Heading).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK__Events__GroupId__09746778");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__Events__ParentId__0A688BB1");

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.ToUserId)
                    .HasConstraintName("FK__Events__ToUserId__0B5CAFEA");
            });

            modelBuilder.Entity<Family>(entity =>
            {
                entity.ToTable("Family");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.RelationType)
                    .WithMany(p => p.Families)
                    .HasForeignKey(d => d.RelationTypeId)
                    .HasConstraintName("FK__Family__Relation__0C50D423");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Families)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Family__UserId__0D44F85C");
            });

            modelBuilder.Entity<FamilyContact>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Family)
                    .WithMany(p => p.FamilyContacts)
                    .HasForeignKey(d => d.FamilyId)
                    .HasConstraintName("FK__FamilyCon__Famil__0E391C95");
            });

            modelBuilder.Entity<FamilyEducationDetail>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.YearOfpassout).HasColumnName("YearOFPassout");

                entity.HasOne(d => d.Family)
                    .WithMany(p => p.FamilyEducationDetails)
                    .HasForeignKey(d => d.FamilyId)
                    .HasConstraintName("FK__FamilyEdu__Famil__0F2D40CE");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.FamilyEducationDetails)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK__FamilyEdu__Insti__10216507");

                entity.HasOne(d => d.Qulificationtype)
                    .WithMany(p => p.FamilyEducationDetails)
                    .HasForeignKey(d => d.QulificationtypeId)
                    .HasConstraintName("FK__FamilyEdu__Qulif__11158940");
            });

            modelBuilder.Entity<FamilyEmail>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.InstitutionAddress)
                    .WithMany(p => p.FamilyEmails)
                    .HasForeignKey(d => d.InstitutionAddressId)
                    .HasConstraintName("FK__FamilyEma__Insti__1209AD79");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("Group");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Heading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Heading ");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<IndustryType>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InstitutionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Medium)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.MediumId)
                    .HasConstraintName("FK__Instituti__Mediu__1C873BEC");

                entity.HasOne(d => d.QulificationType)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.QulificationTypeId)
                    .HasConstraintName("FK__Instituti__Qulif__1D7B6025");
            });

            modelBuilder.Entity<InstitutionAddress>(entity =>
            {
                entity.ToTable("InstitutionAddress");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FlotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.InstitutionAddresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__Instituti__Count__12FDD1B2");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.InstitutionAddressInstitutions)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK__Instituti__Insti__13F1F5EB");

                entity.HasOne(d => d.Meduim)
                    .WithMany(p => p.InstitutionAddresses)
                    .HasForeignKey(d => d.MeduimId)
                    .HasConstraintName("FK__Instituti__Medui__14E61A24");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.InstitutionAddressStates)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__Instituti__State__15DA3E5D");
            });

            modelBuilder.Entity<InstitutionContact>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.InstitutionAddress)
                    .WithMany(p => p.InstitutionContacts)
                    .HasForeignKey(d => d.InstitutionAddressId)
                    .HasConstraintName("FK__Instituti__Insti__16CE6296");
            });

            modelBuilder.Entity<InstitutionCourse>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.InstitutionCourses)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__Instituti__Cours__17C286CF");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.InstitutionCourses)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK__Instituti__Insti__18B6AB08");
            });

            modelBuilder.Entity<InstitutionEmail>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.InstitutionAddress)
                    .WithMany(p => p.InstitutionEmails)
                    .HasForeignKey(d => d.InstitutionAddressId)
                    .HasConstraintName("FK__Instituti__Insti__19AACF41");
            });

            modelBuilder.Entity<InstitutionJob>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.InstitutionJobs)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitutionJobs_InstitutionId");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.InstitutionJobs)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitutionJobs_JobId");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job");

                entity.Property(e => e.ClosingDate).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Pay).HasColumnType("money");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.RequireCv).HasColumnName("Require_CV");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Job_Department");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_Job_Location");
            });

            modelBuilder.Entity<JobJobType>(entity =>
            {
                entity.ToTable("Job_JobTypes");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobJobTypes)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Job_JobTypes_JobId");

                entity.HasOne(d => d.JobType)
                    .WithMany(p => p.JobJobTypes)
                    .HasForeignKey(d => d.JobTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Job_JobTypes_JobTypeId");
            });

            modelBuilder.Entity<JobSchedule>(entity =>
            {
                entity.ToTable("JobSchedule");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobSchedules)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSchedule_JobId");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.JobSchedules)
                    .HasForeignKey(d => d.ScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSchedule_ScheduleId");
            });

            modelBuilder.Entity<JobSupplementalPay>(entity =>
            {
                entity.ToTable("JobSupplementalPay");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobSupplementalPays)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSupplementalPay_JobId");

                entity.HasOne(d => d.SupplementalPay)
                    .WithMany(p => p.JobSupplementalPays)
                    .HasForeignKey(d => d.SupplementalPayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSupplementalPay_SupplementalPayId");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<LookUp>(entity =>
            {
                entity.ToTable("LookUp");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<LookUpValue>(entity =>
            {
                entity.ToTable("LookUpValue");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<MarritalStatus>(entity =>
            {
                entity.ToTable("MarritalStatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Medium>(entity =>
            {
                entity.ToTable("Medium");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TargetName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MenuList>(entity =>
            {
                entity.HasKey(e => e.MId);

                entity.ToTable("Menu_List");

                entity.Property(e => e.MId).HasColumnName("M_ID");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTION_NAME");

                entity.Property(e => e.ControllerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTROLLER_NAME");

                entity.Property(e => e.MName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("M_NAME");

                entity.Property(e => e.MPId).HasColumnName("M_P_ID");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Heading).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK__News__GroupId__2610A626");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__News__ParentId__2704CA5F");

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.ToUserId)
                    .HasConstraintName("FK__News__ToUserId__27F8EE98");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Orders__PersonID__28ED12D1");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__persons__C577554068089528");

                entity.ToTable("persons");

                entity.Property(e => e.Pid).HasColumnName("PId");

                entity.Property(e => e.FerstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Heading)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsPublish)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Question1)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("Question");
            });

            modelBuilder.Entity<QuestionCategory>(entity =>
            {
                entity.ToTable("QuestionCategory");

                entity.HasIndex(e => e.Guid, "UQ__Question__A2B5777D5C02E3BE")
                    .IsUnique();

                entity.HasIndex(e => e.Guid, "UQ__Question__A2B5777D65EC9684")
                    .IsUnique();

                entity.HasIndex(e => e.Guid, "UQ__Question__A2B5777DB96B26B9")
                    .IsUnique();

                entity.HasIndex(e => e.Guid, "UQ__Question__A2B5777DBB34F98B")
                    .IsUnique();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifieDt).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionCategory1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("QuestionCategory");
            });

            modelBuilder.Entity<QuestionOption>(entity =>
            {
                entity.ToTable("QuestionOption");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Option).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionOptions)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_QuestionOption_QuestionId");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.QuestionOptions)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_QuestionOption_StatusId");
            });

            modelBuilder.Entity<QuestionType>(entity =>
            {
                entity.ToTable("QuestionType");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.QuestionType1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("QuestionType");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<QulificationType>(entity =>
            {
                entity.ToTable("QulificationType");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Referral>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RefferalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.EducationQualification)
                    .WithMany(p => p.Referrals)
                    .HasForeignKey(d => d.EducationQualificationId)
                    .HasConstraintName("FK__Referrals__Educa__29E1370A");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Referrals)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__Referrals__State__2AD55B43");
            });

            modelBuilder.Entity<RelationType>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Heading)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Heading ");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReviewsComment>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.ReviewsComments)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReviewsComments");

                entity.HasOne(d => d.Review)
                    .WithMany(p => p.ReviewsComments)
                    .HasForeignKey(d => d.ReviewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReviewsComments_Review");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReviewsComments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReviewsComments_User");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<RoleCategory>(entity =>
            {
                entity.ToTable("RoleCategory");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Sprint>(entity =>
            {
                entity.ToTable("Sprint");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<SprintTask>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Sprint)
                    .WithMany(p => p.SprintTasks)
                    .HasForeignKey(d => d.SprintId)
                    .HasConstraintName("FK_SprintTasks_SprintId");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.SprintTasks)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_SprintTasks_StatusId");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.SprintTasks)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_SprintTasks_TaskId");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TaskComment>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskComments)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TaskComments_TaskId");
            });

            modelBuilder.Entity<TaskCommentDocument>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.File).IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.FileType).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.TaskComment)
                    .WithMany(p => p.TaskCommentDocuments)
                    .HasForeignKey(d => d.TaskCommentId)
                    .HasConstraintName("FK_TaskCommentDocuments_TaskCommentsId");
            });

            modelBuilder.Entity<TaskDocument>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.File).IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.FileType).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskDocuments)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TaskDocuments_TaskId");
            });

            modelBuilder.Entity<TaskLog>(entity =>
            {
                entity.ToTable("TaskLog");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskLogs)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TaskLog_TaskId");
            });

            modelBuilder.Entity<TaskState>(entity =>
            {
                entity.ToTable("TaskState");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.AssignedNavigation)
                    .WithMany(p => p.TaskStates)
                    .HasForeignKey(d => d.Assigned)
                    .HasConstraintName("FK_TaskState_Assigned");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskStates)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TaskState_TaskId");
            });

            modelBuilder.Entity<Template>(entity =>
            {
                entity.ToTable("Template");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tempalte).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Templates)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__Template__TypeId__373B3228");
            });

            modelBuilder.Entity<TemplateType>(entity =>
            {
                entity.ToTable("TemplateType");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PanCardNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.RefferalCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Username).IsUnicode(false);

                entity.Property(e => e.VoterId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK__Users__GenderId__477199F1");

                entity.HasOne(d => d.MarritalStatus)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.MarritalStatusId)
                    .HasConstraintName("FK__Users__MarritalS__4865BE2A");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK__Users__UserTypeI__4959E263");
            });

            modelBuilder.Entity<UserAddressDetail>(entity =>
            {
                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FlotNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.UserAddressDetails)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__UserAddre__Count__382F5661");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.UserAddressDetails)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__UserAddre__State__39237A9A");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.UserAddressDetails)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__UserAddre__TypeI__3A179ED3");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAddressDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserAddre__UserI__3B0BC30C");
            });

            modelBuilder.Entity<UserCompany>(entity =>
            {
                entity.ToTable("UserCompany");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.OfferDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserCompanies)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__UserCompa__Compa__3BFFE745");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.UserCompanies)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("FK__UserCompa__Desig__3CF40B7E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCompanies)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserCompa__UserI__3DE82FB7");
            });

            modelBuilder.Entity<UserContact>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.UserContacts)
                    .HasForeignKey(d => d.ContactTypeId)
                    .HasConstraintName("FK__UserConta__Conta__3EDC53F0");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserContacts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserConta__UserI__3FD07829");
            });

            modelBuilder.Entity<UserCourse>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.UserCourses)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__UserCours__Cours__40C49C62");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCourses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserCours__UserI__41B8C09B");
            });

            modelBuilder.Entity<UserEducationDetail>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.YearOfpassout).HasColumnName("YearOFPassout");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.UserEducationDetails)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK__UserEduca__Insti__42ACE4D4");

                entity.HasOne(d => d.Qulificationtype)
                    .WithMany(p => p.UserEducationDetails)
                    .HasForeignKey(d => d.QulificationtypeId)
                    .HasConstraintName("FK__UserEduca__Qulif__43A1090D");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserEducationDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserEduca__UserI__44952D46");
            });

            modelBuilder.Entity<UserEmail>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.UserEmails)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__UserEmail__TypeI__4589517F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserEmails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserEmail__UserI__467D75B8");
            });

            modelBuilder.Entity<UserExam>(entity =>
            {
                entity.ToTable("UserExam");

                entity.Property(e => e.CloseOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.StartOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedon).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserExams)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserExams_UserId");
            });

            modelBuilder.Entity<UserExamQuestion>(entity =>
            {
                entity.Property(e => e.Answer).IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.UserExamQuestions)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_UserExamQuestions_Question");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserExamQuestions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserExamQuestions_User");
            });

            modelBuilder.Entity<UserExamQuestionsAudit>(entity =>
            {
                entity.ToTable("UserExamQuestionsAudit");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.UserExamQuestionsAudits)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_UserExamQuestionsAudit_StatusId");

                entity.HasOne(d => d.UserExamQuestion)
                    .WithMany(p => p.UserExamQuestionsAudits)
                    .HasForeignKey(d => d.UserExamQuestionId)
                    .HasConstraintName("FK_UserExamQuestionsAudit_UserExamQuestionId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserExamQuestionsAudits)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserExamQuestionsAudit_UserId");
            });

            modelBuilder.Entity<UserProfileQuestion>(entity =>
            {
                entity.ToTable("UserProfileQuestion");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.MarkForReview).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.NotAnswered).HasDefaultValueSql("((0))");

                entity.Property(e => e.OptionText).IsUnicode(false);

                entity.Property(e => e.Visited).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UserSkill>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.UserSkills)
                    .HasForeignKey(d => d.SkillId)
                    .HasConstraintName("FK__UserSkill__Skill__4A4E069C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSkills)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserSkill__UserI__4B422AD5");
            });

            modelBuilder.Entity<UserTokenSession>(entity =>
            {
                entity.ToTable("UserTokenSession");

                entity.Property(e => e.BrowserInfo).HasMaxLength(250);

                entity.Property(e => e.DeviceType).HasMaxLength(50);

                entity.Property(e => e.IpAddress).HasMaxLength(50);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OperatingSystem).HasMaxLength(100);

                entity.Property(e => e.SessionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TokenExpires).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(450);
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<VacanciesSkill>(entity =>
            {
                entity.ToTable("VacanciesSkill");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.VacanciesSkills)
                    .HasForeignKey(d => d.SkillId)
                    .HasConstraintName("FK_VacanciesSkill_Skills");

                entity.HasOne(d => d.Vacancy)
                    .WithMany(p => p.VacanciesSkills)
                    .HasForeignKey(d => d.VacancyId)
                    .HasConstraintName("FK_VacanciesSkill_Vacancies");
            });

            modelBuilder.Entity<Vacancy>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.VacancyCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Vacancies_CreatedBy");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Vacancies)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Vacancies_Department");

                entity.HasOne(d => d.EducationType)
                    .WithMany(p => p.VacancyEducationTypes)
                    .HasForeignKey(d => d.EducationTypeId)
                    .HasConstraintName("FK_Vacancies_EducationType");

                entity.HasOne(d => d.EmploymentType)
                    .WithMany(p => p.VacancyEmploymentTypes)
                    .HasForeignKey(d => d.EmploymentTypeId)
                    .HasConstraintName("FK_Vacancies_EmploymentTypes");

                entity.HasOne(d => d.IndustryType)
                    .WithMany(p => p.Vacancies)
                    .HasForeignKey(d => d.IndustryTypeId)
                    .HasConstraintName("FK_Vacancies_IndustryType");

                entity.HasOne(d => d.RoleCategory)
                    .WithMany(p => p.Vacancies)
                    .HasForeignKey(d => d.RoleCategoryId)
                    .HasConstraintName("FK_Vacancies_RoleCategory");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Vacancies)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Vacancies_Role");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Vacancies)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Vacancies_Status");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.VacancyUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Vacancies_UpdatedBy");
            });

            modelBuilder.Entity<YearSemester>(entity =>
            {
                entity.ToTable("YearSemester");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CyearsId).HasColumnName("CYearsId");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Cyears)
                    .WithMany(p => p.YearSemesters)
                    .HasForeignKey(d => d.CyearsId)
                    .HasConstraintName("FK__YearSemes__CYear__56B3DD81");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.YearSemesters)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK__YearSemes__Semes__57A801BA");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
