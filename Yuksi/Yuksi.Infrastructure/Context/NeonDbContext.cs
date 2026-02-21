using Microsoft.EntityFrameworkCore;
using Yuks.Domain;
using Yuksi.Domain;
using Yuksi.Domain.Enums;
using Yuksİ.Domain;
using VehicleFeature = Yuksi.Domain.Enums.VehicleFeature;

namespace Yuksi.Infrastructure;

public partial class NeonDbContext : DbContext
{
    public NeonDbContext(DbContextOptions<NeonDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AdminJob> AdminJobs { get; set; }

    public virtual DbSet<ApplicationReview> ApplicationReviews { get; set; }

    public virtual DbSet<Arcdict> Arcdicts { get; set; }

    public virtual DbSet<BankAccount> BankAccounts { get; set; }

    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<Blacklist> Blacklists { get; set; }

    public virtual DbSet<BusinessCompany> BusinessCompanies { get; set; }

    public virtual DbSet<BusinessPartner> BusinessPartners { get; set; }

    public virtual DbSet<BusinessUser> BusinessUsers { get; set; }

    public virtual DbSet<Campaign> Campaigns { get; set; }

    public virtual DbSet<CargoUser> CargoUsers { get; set; }

    public virtual DbSet<Cargotype> Cargotypes { get; set; }

    public virtual DbSet<CarrierApplication> CarrierApplications { get; set; }

    public virtual DbSet<CarrierKmPrice> CarrierKmPrices { get; set; }

    public virtual DbSet<CarrierPackage> CarrierPackages { get; set; }

    public virtual DbSet<CarrierPackageSubscription> CarrierPackageSubscriptions { get; set; }

    public virtual DbSet<CarrierSubscriptionRequest> CarrierSubscriptionRequests { get; set; }

    public virtual DbSet<CarrierType> CarrierTypes { get; set; }

    public virtual DbSet<Chat> Chats { get; set; }

    public virtual DbSet<ChatMessage> ChatMessages { get; set; }

    public virtual DbSet<ChatParticipant> ChatParticipants { get; set; }

    public virtual DbSet<ChatsNew> ChatsNews { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<CityPrice> CityPrices { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyManager> CompanyManagers { get; set; }

    public virtual DbSet<CompanyPackage> CompanyPackages { get; set; }

    public virtual DbSet<ContactMessage> ContactMessages { get; set; }

    public virtual DbSet<CorporateActivationPricing> CorporateActivationPricings { get; set; }

    public virtual DbSet<CorporateContactMessage> CorporateContactMessages { get; set; }

    public virtual DbSet<CorporateUser> CorporateUsers { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CourierBreak> CourierBreaks { get; set; }

    public virtual DbSet<CourierBreakSession> CourierBreakSessions { get; set; }

    public virtual DbSet<CourierBreakSetting> CourierBreakSettings { get; set; }

    public virtual DbSet<CourierDocument> CourierDocuments { get; set; }

    public virtual DbSet<CourierOrdersLog> CourierOrdersLogs { get; set; }

    public virtual DbSet<CourierPackage> CourierPackages { get; set; }

    public virtual DbSet<CourierPackageSubscription> CourierPackageSubscriptions { get; set; }

    public virtual DbSet<CourierRating> CourierRatings { get; set; }

    public virtual DbSet<CourierSubscriptionRequest> CourierSubscriptionRequests { get; set; }

    public virtual DbSet<Dealer> Dealers { get; set; }

    public virtual DbSet<DealerCompany> DealerCompanies { get; set; }

    public virtual DbSet<DealerCompany1> DealerCompanies1 { get; set; }

    public virtual DbSet<DealerFormMessage> DealerFormMessages { get; set; }

    public virtual DbSet<DealerRestaurant> DealerRestaurants { get; set; }

    public virtual DbSet<DeviceToken> DeviceTokens { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<Driver> Drivers { get; set; }

    public virtual DbSet<DriverActive> DriverActives { get; set; }

    public virtual DbSet<DriverOnboarding> DriverOnboardings { get; set; }

    public virtual DbSet<DriverPresenceEvent> DriverPresenceEvents { get; set; }

    public virtual DbSet<DriverStatus> DriverStatuses { get; set; }

    public virtual DbSet<DriverWorkTime> DriverWorkTimes { get; set; }

    public virtual DbSet<ExtraService> ExtraServices { get; set; }

    public virtual DbSet<File> Files { get; set; }

    public virtual DbSet<GeneralSetting> GeneralSettings { get; set; }

    public virtual DbSet<GpsTable> GpsTables { get; set; }

    public virtual DbSet<HelpMessage> HelpMessages { get; set; }

    public virtual DbSet<IlanKategorileri> IlanKategorileris { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<KurumsalPackage> KurumsalPackages { get; set; }

    public virtual DbSet<KurumsalPackageSubscription> KurumsalPackageSubscriptions { get; set; }

    public virtual DbSet<KurumsalSubscriptionRequest> KurumsalSubscriptionRequests { get; set; }

    public virtual DbSet<MarketerCommission> MarketerCommissions { get; set; }

    public virtual DbSet<MarketerCommissionRate> MarketerCommissionRates { get; set; }

    public virtual DbSet<MarketerLocation> MarketerLocations { get; set; }

    public virtual DbSet<MarketerShift> MarketerShifts { get; set; }

    public virtual DbSet<MarketerUser> MarketerUsers { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<MessagesNew> MessagesNews { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<OnboardingCorporate> OnboardingCorporates { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<OrderWatcher> OrderWatchers { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<PartnerUser> PartnerUsers { get; set; }

    public virtual DbSet<PasswordResetToken> PasswordResetTokens { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Picture> Pictures { get; set; }

    public virtual DbSet<PoolOrder> PoolOrders { get; set; }

    public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    public virtual DbSet<RestaurantCourier> RestaurantCouriers { get; set; }

    public virtual DbSet<RestaurantMenu> RestaurantMenus { get; set; }

    public virtual DbSet<RestaurantPackagePrice> RestaurantPackagePrices { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<SiteContactMessage> SiteContactMessages { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Subsection> Subsections { get; set; }

    public virtual DbSet<SupportTicket> SupportTickets { get; set; }

    public virtual DbSet<SupportTicketsCourier> SupportTicketsCouriers { get; set; }

    public virtual DbSet<SupportUser> SupportUsers { get; set; }

    public virtual DbSet<SystemAdmin> SystemAdmins { get; set; }

    public virtual DbSet<TicarimAltKategoriler> TicarimAltKategorilers { get; set; }

    public virtual DbSet<TicarimAnaKategoriler> TicarimAnaKategorilers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAddress> UserAddresses { get; set; }

    public virtual DbSet<UserJob> UserJobs { get; set; }

    public virtual DbSet<UserJobOffer> UserJobOffers { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<VehicleCapacityOption> VehicleCapacityOptions { get; set; }

    public virtual DbSet<VehicleFeature> VehicleFeatures { get; set; }

    public virtual DbSet<VehicleListing> VehicleListings { get; set; }

    public virtual DbSet<VehicleListingImage> VehicleListingImages { get; set; }

    public virtual DbSet<VehiclePhoto> VehiclePhotos { get; set; }

    public virtual DbSet<VehicleProduct> VehicleProducts { get; set; }

    public virtual DbSet<VehicleType> VehicleTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresEnum<ContactMessageStatus>()
            .HasPostgresEnum<ContentType>()
            .HasPostgresEnum<CourierDocType>()
            .HasPostgresEnum<CourierDocumentStatus>()
            .HasPostgresEnum<CourierOrderAction>()
            .HasPostgresEnum<DeliveryType>()
            .HasPostgresEnum<DocType>()
            .HasPostgresEnum<JobStatus>()
            .HasPostgresEnum<OrderStatus>()
            .HasPostgresEnum<OrderType>()
            .HasPostgresEnum<VehicleFeature>()
            .HasPostgresEnum<VehicleTemplate>()
            .HasPostgresExtension("pgcrypto")
            .HasPostgresExtension("uuid-ossp");

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("addresses_pkey");

            entity.ToTable("addresses");

            entity.HasIndex(e => e.City, "idx_addresses_city");

            entity.HasIndex(e => new { e.EntityType, e.EntityId, e.IsDefault }, "idx_addresses_default").HasFilter("((is_default = true) AND (deleted = false))");

            entity.HasIndex(e => new { e.City, e.District }, "idx_addresses_district");

            entity.HasIndex(e => new { e.EntityType, e.EntityId }, "idx_addresses_entity").HasFilter("(deleted = false)");

            entity.HasIndex(e => e.EntityType, "idx_addresses_entity_type").HasFilter("(deleted = false)");

            entity.HasIndex(e => e.PostalCode, "idx_addresses_postal_code");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.AddressTitle)
                .HasMaxLength(100)
                .HasColumnName("address_title");
            entity.Property(e => e.AddressType)
                .HasMaxLength(50)
                .HasDefaultValueSql("'main'::character varying")
                .HasColumnName("address_type");
            entity.Property(e => e.ApartmentNumber)
                .HasMaxLength(20)
                .HasColumnName("apartment_number");
            entity.Property(e => e.BuildingNumber)
                .HasMaxLength(20)
                .HasColumnName("building_number");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasColumnName("city");
            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .HasColumnName("contact_name");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(20)
                .HasColumnName("contact_phone");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.District)
                .HasMaxLength(100)
                .HasColumnName("district");
            entity.Property(e => e.EntityId).HasColumnName("entity_id");
            entity.Property(e => e.EntityType)
                .HasMaxLength(50)
                .HasColumnName("entity_type");
            entity.Property(e => e.Floor)
                .HasMaxLength(10)
                .HasColumnName("floor");
            entity.Property(e => e.FullAddress).HasColumnName("full_address");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.IsDefault)
                .HasDefaultValue(false)
                .HasColumnName("is_default");
            entity.Property(e => e.Latitude)
                .HasPrecision(10, 8)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasPrecision(11, 8)
                .HasColumnName("longitude");
            entity.Property(e => e.Neighborhood)
                .HasMaxLength(200)
                .HasColumnName("neighborhood");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(10)
                .HasColumnName("postal_code");
            entity.Property(e => e.Street)
                .HasMaxLength(200)
                .HasColumnName("street");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<AdminJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("admin_jobs_pkey");

            entity.ToTable("admin_jobs");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CampaignCode).HasColumnName("campaign_code");
            entity.Property(e => e.CarrierType).HasColumnName("carrier_type");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CorporateId).HasColumnName("corporate_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedByAdmin)
                .HasDefaultValue(false)
                .HasColumnName("created_by_admin");
            entity.Property(e => e.DealerId).HasColumnName("dealer_id");
            entity.Property(e => e.DeliveryDate).HasColumnName("delivery_date");
            entity.Property(e => e.DeliveryTime).HasColumnName("delivery_time");
            entity.Property(e => e.DeliveryType).HasColumnName("delivery_type");
            entity.Property(e => e.DropoffAddress).HasColumnName("dropoff_address");
            entity.Property(e => e.DropoffCoordinates)
                .HasColumnType("jsonb")
                .HasColumnName("dropoff_coordinates");
            entity.Property(e => e.ExtraServices)
                .HasColumnType("jsonb")
                .HasColumnName("extra_services");
            entity.Property(e => e.ExtraServicesTotal)
                .HasDefaultValue(0m)
                .HasColumnName("extra_services_total");
            entity.Property(e => e.ImageFileIds)
                .HasDefaultValueSql("'[]'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("image_file_ids");
            entity.Property(e => e.PaymentMethod).HasColumnName("payment_method");
            entity.Property(e => e.PickupAddress).HasColumnName("pickup_address");
            entity.Property(e => e.PickupCoordinates)
                .HasColumnType("jsonb")
                .HasColumnName("pickup_coordinates");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");
            entity.Property(e => e.SpecialNotes).HasColumnName("special_notes");
            entity.Property(e => e.TotalPrice).HasColumnName("total_price");
            entity.Property(e => e.VehicleProductId).HasColumnName("vehicle_product_id");
            entity.Property(e => e.VehicleType).HasColumnName("vehicle_type");

            entity.HasOne(d => d.Company).WithMany(p => p.AdminJobs)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("admin_jobs_company_id_fkey");

            entity.HasOne(d => d.Corporate).WithMany(p => p.AdminJobs)
                .HasForeignKey(d => d.CorporateId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("admin_jobs_corporate_id_fkey");

            entity.HasOne(d => d.Dealer).WithMany(p => p.AdminJobs)
                .HasForeignKey(d => d.DealerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("admin_jobs_dealer_id_fkey");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.AdminJobs)
                .HasForeignKey(d => d.RestaurantId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("admin_jobs_restaurant_id_fkey");

            entity.HasOne(d => d.VehicleTypeNavigation).WithMany(p => p.AdminJobs)
                .HasPrincipalKey(p => p.Type)
                .HasForeignKey(d => d.VehicleType)
                .HasConstraintName("admin_jobs_vehicle_type_fkey");
        });

        modelBuilder.Entity<ApplicationReview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("application_reviews_pkey");

            entity.ToTable("application_reviews");

            entity.HasIndex(e => e.ReviewedAt, "idx_application_reviews_reviewed_at").IsDescending();

            entity.HasIndex(e => e.ReviewedBy, "idx_application_reviews_reviewed_by");

            entity.HasIndex(e => e.Status, "idx_application_reviews_status");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationId }, "idx_application_reviews_type_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.ApplicationId).HasColumnName("application_id");
            entity.Property(e => e.ApplicationType).HasColumnName("application_type");
            entity.Property(e => e.CallDurationSeconds).HasColumnName("call_duration_seconds");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.ReviewNotes).HasColumnName("review_notes");
            entity.Property(e => e.ReviewedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("reviewed_at");
            entity.Property(e => e.ReviewedBy).HasColumnName("reviewed_by");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.ReviewedByNavigation).WithMany(p => p.ApplicationReviews)
                .HasForeignKey(d => d.ReviewedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("application_reviews_reviewed_by_fkey");
        });

        modelBuilder.Entity<Arcdict>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("arcdict_pkey");

            entity.ToTable("arcdict");

            entity.HasIndex(e => e.Key, "arcdict_key_key").IsUnique();

            entity.HasIndex(e => e.Key, "idx_arcdict_key");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<BankAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bank_accounts_pkey");

            entity.ToTable("bank_accounts");

            entity.HasIndex(e => new { e.IsActive, e.DisplayOrder }, "idx_bank_accounts_active");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.AccountHolder).HasColumnName("account_holder");
            entity.Property(e => e.AccountNumber).HasColumnName("account_number");
            entity.Property(e => e.BankName).HasColumnName("bank_name");
            entity.Property(e => e.BranchName).HasColumnName("branch_name");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DisplayOrder)
                .HasDefaultValue(0)
                .HasColumnName("display_order");
            entity.Property(e => e.Iban).HasColumnName("iban");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Banner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("banners_pkey");

            entity.ToTable("banners");

            entity.HasIndex(e => new { e.Active, e.Priority, e.Title }, "idx_banners_active_priority_title").IsDescending(true, true, false);

            entity.HasIndex(e => e.Active, "ix_banners_active");

            entity.HasIndex(e => e.Priority, "ix_banners_priority").IsDescending();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.ImageUrl).HasColumnName("image_url");
            entity.Property(e => e.Priority)
                .HasDefaultValue(0)
                .HasColumnName("priority");
            entity.Property(e => e.Title).HasColumnName("title");
        });

        modelBuilder.Entity<Blacklist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("blacklist_pkey");

            entity.ToTable("blacklist");

            entity.HasIndex(e => e.AddedAt, "idx_blacklist_added_at").IsDescending();

            entity.HasIndex(e => e.Email, "idx_blacklist_email");

            entity.HasIndex(e => e.IsActive, "idx_blacklist_is_active");

            entity.HasIndex(e => e.Phone, "idx_blacklist_phone");

            entity.HasIndex(e => new { e.ApplicationType, e.ApplicationId }, "idx_blacklist_type_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.AddedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("added_at");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.ApplicationId).HasColumnName("application_id");
            entity.Property(e => e.ApplicationType).HasColumnName("application_type");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Reason).HasColumnName("reason");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.AddedByNavigation).WithMany(p => p.Blacklists)
                .HasForeignKey(d => d.AddedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("blacklist_added_by_fkey");
        });

        modelBuilder.Entity<BusinessCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("business_companies_pkey");

            entity.ToTable("business_companies");

            entity.HasIndex(e => e.UserId, "business_companies_user_id_key").IsUnique();

            entity.HasIndex(e => e.Vkn, "business_companies_vkn_key").IsUnique();

            entity.HasIndex(e => e.UserId, "idx_business_companies_user_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(200)
                .HasColumnName("company_name");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.TaxOffice)
                .HasMaxLength(100)
                .HasColumnName("tax_office");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Vkn)
                .HasMaxLength(10)
                .HasColumnName("vkn");

            entity.HasOne(d => d.User).WithOne(p => p.BusinessCompany)
                .HasForeignKey<BusinessCompany>(d => d.UserId)
                .HasConstraintName("business_companies_user_id_fkey");
        });

        modelBuilder.Entity<BusinessPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("business_partners_pkey");

            entity.ToTable("business_partners");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.District).HasColumnName("district");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.LogoImageUrl).HasColumnName("logo_image_url");
            entity.Property(e => e.PublishDate).HasColumnName("publish_date");
            entity.Property(e => e.ServiceArea).HasColumnName("service_area");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<BusinessUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("business_users_pkey");

            entity.ToTable("business_users");

            entity.HasIndex(e => e.Email, "business_users_email_key").IsUnique();

            entity.HasIndex(e => e.Deleted, "idx_business_users_deleted").HasFilter("(deleted = false)");

            entity.HasIndex(e => e.Email, "idx_business_users_email");

            entity.HasIndex(e => e.Status, "idx_business_users_status");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'PASSIVE_NO_PAYMENT'::text")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Campaign>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("campaigns_pkey");

            entity.ToTable("campaigns");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DiscountRate).HasColumnName("discount_rate");
            entity.Property(e => e.Rule).HasColumnName("rule");
            entity.Property(e => e.Title).HasColumnName("title");
        });

        modelBuilder.Entity<CargoUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cargo_users_pkey");

            entity.ToTable("cargo_users");

            entity.HasIndex(e => new { e.UserType, e.UserId }, "cargo_users_user_type_user_id_key").IsUnique();

            entity.HasIndex(e => e.UpdatedAt, "idx_cargo_users_updated_at").IsDescending();

            entity.HasIndex(e => new { e.UserType, e.UserId }, "idx_cargo_users_user");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CargoPassword).HasColumnName("cargo_password");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.RefreshToken).HasColumnName("refresh_token");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserType).HasColumnName("user_type");
        });

        modelBuilder.Entity<Cargotype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cargotypes_pkey");

            entity.ToTable("cargotypes");

            entity.HasIndex(e => e.CreatedAt, "idx_cargotypes_created_at").IsDescending();

            entity.HasIndex(e => e.CreatedAt, "ix_cargotypes_created_at").IsDescending();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<CarrierApplication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("carrier_applications_pkey");

            entity.ToTable("carrier_applications");

            entity.HasIndex(e => e.City, "idx_carrier_applications_city");

            entity.HasIndex(e => e.CreatedAt, "idx_carrier_applications_created_at").IsDescending();

            entity.HasIndex(e => e.Status, "idx_carrier_applications_status");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CarrierDocumentsUrl).HasColumnName("carrier_documents_url");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            entity.Property(e => e.ReviewedAt).HasColumnName("reviewed_at");
            entity.Property(e => e.ReviewedBy).HasColumnName("reviewed_by");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'pending'::text")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.VehicleDocumentsUrl).HasColumnName("vehicle_documents_url");
            entity.Property(e => e.VehicleRegistrationYear).HasColumnName("vehicle_registration_year");
            entity.Property(e => e.VehicleType).HasColumnName("vehicle_type");
        });

        modelBuilder.Entity<CarrierKmPrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("carrier_km_prices_pkey");

            entity.ToTable("carrier_km_prices");

            entity.HasIndex(e => new { e.AreaType, e.VehicleTemplate }, "carrier_km_prices_area_type_vehicle_template_key").IsUnique();

            entity.HasIndex(e => new { e.AreaType, e.VehicleTemplate }, "idx_carrier_km_prices_area_template");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.AreaType).HasColumnName("area_type");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.PricePerKm)
                .HasPrecision(10, 2)
                .HasColumnName("price_per_km");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.VehicleTemplate).HasColumnName("vehicle_template");
        });

        modelBuilder.Entity<CarrierPackage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("carrier_packages_pkey");

            entity.ToTable("carrier_packages");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.DurationDays).HasColumnName("duration_days");
            entity.Property(e => e.PackageName)
                .HasMaxLength(100)
                .HasColumnName("package_name");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
        });

        modelBuilder.Entity<CarrierPackageSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("carrier_package_subscriptions_pkey");

            entity.ToTable("carrier_package_subscriptions");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CourierId).HasColumnName("courier_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");

            entity.HasOne(d => d.Courier).WithMany(p => p.CarrierPackageSubscriptions)
                .HasForeignKey(d => d.CourierId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("carrier_package_subscriptions_courier_id_fkey");

            entity.HasOne(d => d.Package).WithMany(p => p.CarrierPackageSubscriptions)
                .HasForeignKey(d => d.PackageId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("carrier_package_subscriptions_package_id_fkey");
        });

        modelBuilder.Entity<CarrierSubscriptionRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("carrier_subscription_requests_pkey");

            entity.ToTable("carrier_subscription_requests");

            entity.HasIndex(e => e.MerchantOid, "carrier_subscription_requests_merchant_oid_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CourierId).HasColumnName("courier_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.MerchantOid).HasColumnName("merchant_oid");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.PaymentStatus)
                .HasDefaultValueSql("'pending'::text")
                .HasColumnName("payment_status");
            entity.Property(e => e.StartDate).HasColumnName("start_date");

            entity.HasOne(d => d.Courier).WithMany(p => p.CarrierSubscriptionRequests)
                .HasForeignKey(d => d.CourierId)
                .HasConstraintName("carrier_subscription_requests_courier_id_fkey");

            entity.HasOne(d => d.Package).WithMany(p => p.CarrierSubscriptionRequests)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("carrier_subscription_requests_package_id_fkey");
        });

        modelBuilder.Entity<CarrierType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("carrier_types_pkey");

            entity.ToTable("carrier_types");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.ImageFileId).HasColumnName("image_file_id");
            entity.Property(e => e.KmPrice)
                .HasPrecision(10, 2)
                .HasColumnName("km_price");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.StartKm).HasColumnName("start_km");
            entity.Property(e => e.StartPrice)
                .HasPrecision(10, 2)
                .HasColumnName("start_price");

            entity.HasOne(d => d.ImageFile).WithMany(p => p.CarrierTypes)
                .HasForeignKey(d => d.ImageFileId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("carrier_types_image_file_id_fkey");
        });

        modelBuilder.Entity<Chat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("chats_pkey");

            entity.ToTable("chats");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.IsGroup)
                .HasDefaultValue(false)
                .HasColumnName("is_group");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ChatMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("chat_messages_pkey");

            entity.ToTable("chat_messages");

            entity.HasIndex(e => new { e.ChatId, e.MessageId }, "chat_messages_chat_id_message_id_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.ChatId).HasColumnName("chat_id");
            entity.Property(e => e.InsertedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("inserted_at");
            entity.Property(e => e.MessageId).HasColumnName("message_id");

            entity.HasOne(d => d.Chat).WithMany(p => p.ChatMessages)
                .HasForeignKey(d => d.ChatId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("chat_messages_chat_id_fkey");

            entity.HasOne(d => d.Message).WithMany(p => p.ChatMessages)
                .HasForeignKey(d => d.MessageId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("chat_messages_message_id_fkey");
        });

        modelBuilder.Entity<ChatParticipant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("chat_participants_pkey");

            entity.ToTable("chat_participants");

            entity.HasIndex(e => new { e.ChatId, e.UserId, e.UserType }, "chat_participants_chat_id_user_id_user_type_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.ChatId).HasColumnName("chat_id");
            entity.Property(e => e.JoinedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("joined_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserType).HasColumnName("user_type");

            entity.HasOne(d => d.Chat).WithMany(p => p.ChatParticipants)
                .HasForeignKey(d => d.ChatId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("chat_participants_chat_id_fkey");
        });

        modelBuilder.Entity<ChatsNew>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("chats_new_pkey");

            entity.ToTable("chats_new");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FromId).HasColumnName("from_id");
            entity.Property(e => e.ToId).HasColumnName("to_id");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cities");

            entity.HasIndex(e => e.StateId, "idx_cities_state_id");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("country_code");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'2014-01-01 12:01:01'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Flag)
                .HasDefaultValue((short)1)
                .HasColumnName("flag");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Latitude)
                .HasPrecision(10, 8)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasPrecision(11, 8)
                .HasColumnName("longitude");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.StateCode)
                .HasMaxLength(255)
                .HasColumnName("state_code");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.Timezone)
                .HasMaxLength(255)
                .HasColumnName("timezone");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.WikiDataId)
                .HasMaxLength(255)
                .HasColumnName("wikiDataId");
        });

        modelBuilder.Entity<CityPrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("city_prices_pkey");

            entity.ToTable("city_prices");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CourierPrice)
                .HasPrecision(10, 2)
                .HasColumnName("courier_price");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.KamyonPrice)
                .HasPrecision(10, 2)
                .HasColumnName("kamyon_price");
            entity.Property(e => e.KamyonetPrice)
                .HasPrecision(10, 2)
                .HasColumnName("kamyonet_price");
            entity.Property(e => e.MinivanPrice)
                .HasPrecision(10, 2)
                .HasColumnName("minivan_price");
            entity.Property(e => e.PanelvanPrice)
                .HasPrecision(10, 2)
                .HasColumnName("panelvan_price");
            entity.Property(e => e.RouteName).HasColumnName("route_name");
            entity.Property(e => e.StateId).HasColumnName("state_id");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("companies_pkey");

            entity.ToTable("companies");

            entity.HasIndex(e => e.CompanyTrackingNo, "companies_company_tracking_no_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.AssignedKilometers).HasColumnName("assigned_kilometers");
            entity.Property(e => e.CanReceivePayments)
                .HasDefaultValue(true)
                .HasColumnName("can_receive_payments");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.CompanyName).HasColumnName("company_name");
            entity.Property(e => e.CompanyPhone).HasColumnName("company_phone");
            entity.Property(e => e.CompanyTrackingNo).HasColumnName("company_tracking_no");
            entity.Property(e => e.ConsumedKilometers).HasColumnName("consumed_kilometers");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deleted_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsVisible)
                .HasDefaultValue(true)
                .HasColumnName("is_visible");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.SpecialCommissionRate)
                .HasPrecision(5, 2)
                .HasColumnName("special_commission_rate");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'active'::text")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CompanyManager>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("company_managers_pkey");

            entity.ToTable("company_managers");

            entity.HasIndex(e => new { e.CompanyId, e.Email }, "company_managers_company_id_email_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deleted_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.NameSurname).HasColumnName("name_surname");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.Phone).HasColumnName("phone");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyManagers)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("company_managers_company_id_fkey");
        });

        modelBuilder.Entity<CompanyPackage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("company_packages_pkey");

            entity.ToTable("company_packages");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CarrierKm).HasColumnName("carrier_km");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.RequestedKm).HasColumnName("requested_km");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ContactMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("contact_messages_pkey");

            entity.ToTable("contact_messages");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Subject).HasColumnName("subject");
        });

        modelBuilder.Entity<CorporateActivationPricing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("corporate_activation_pricing_pkey");

            entity.ToTable("corporate_activation_pricing");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.GrossPrice)
                .HasPrecision(10, 2)
                .HasColumnName("gross_price");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.VatPercentage)
                .HasPrecision(5, 2)
                .HasDefaultValue(20.00m)
                .HasColumnName("vat_percentage");
        });

        modelBuilder.Entity<CorporateContactMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("corporate_contact_messages_pkey");

            entity.ToTable("corporate_contact_messages");

            entity.HasIndex(e => e.Status, "idx_corporate_contact_messages_status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BusinessName).HasColumnName("business_name");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'pending'::text")
                .HasColumnName("status");
            entity.Property(e => e.Subject).HasColumnName("subject");
        });

        modelBuilder.Entity<CorporateUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("corporate_users_pkey");

            entity.ToTable("corporate_users");

            entity.HasIndex(e => e.Email, "corporate_users_email_unique_idx")
                .IsUnique()
                .HasFilter("((deleted IS NULL) OR (deleted = false))");

            entity.HasIndex(e => e.Platform, "idx_corporate_users_platform");

            entity.HasIndex(e => e.Status, "idx_corporate_users_status");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValueSql("ARRAY[]::integer[]")
                .HasColumnName("access");
            entity.Property(e => e.AddressLine1).HasColumnName("address_line1");
            entity.Property(e => e.AddressLine2).HasColumnName("address_line2");
            entity.Property(e => e.ApartmentNumber)
                .HasMaxLength(20)
                .HasColumnName("apartment_number");
            entity.Property(e => e.BuildingNumber)
                .HasMaxLength(20)
                .HasColumnName("building_number");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasColumnName("city");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.CommissionDescription).HasColumnName("commission_description");
            entity.Property(e => e.CommissionRate)
                .HasPrecision(5, 2)
                .HasColumnName("commission_rate");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(200)
                .HasColumnName("company_name");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.District)
                .HasMaxLength(100)
                .HasColumnName("district");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.Floor)
                .HasMaxLength(10)
                .HasColumnName("floor");
            entity.Property(e => e.Iban).HasColumnName("iban");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.Latitude)
                .HasPrecision(9, 6)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasPrecision(9, 6)
                .HasColumnName("longitude");
            entity.Property(e => e.Neighborhood)
                .HasMaxLength(200)
                .HasColumnName("neighborhood");
            entity.Property(e => e.OnboardingStatus)
                .HasDefaultValue(0)
                .HasColumnName("onboarding_status");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Platform)
                .HasMaxLength(20)
                .HasDefaultValueSql("'yuksi'::character varying")
                .HasColumnName("platform");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(10)
                .HasColumnName("postal_code");
            entity.Property(e => e.Resume).HasColumnName("resume");
            entity.Property(e => e.SetupFeeApprovedAt).HasColumnName("setup_fee_approved_at");
            entity.Property(e => e.SetupFeeApprovedBy).HasColumnName("setup_fee_approved_by");
            entity.Property(e => e.SetupFeePaid)
                .HasDefaultValue(false)
                .HasColumnName("setup_fee_paid");
            entity.Property(e => e.SetupFeePaidAt).HasColumnName("setup_fee_paid_at");
            entity.Property(e => e.SetupFeeRejectionReason).HasColumnName("setup_fee_rejection_reason");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'PASSIVE_NO_PAYMENT'::text")
                .HasColumnName("status");
            entity.Property(e => e.Street)
                .HasMaxLength(200)
                .HasColumnName("street");
            entity.Property(e => e.TaxNumber).HasColumnName("tax_number");
            entity.Property(e => e.TaxOffice).HasColumnName("tax_office");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.Vkn)
                .HasMaxLength(10)
                .HasColumnName("vkn");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("countries");

            entity.Property(e => e.Capital)
                .HasMaxLength(255)
                .HasColumnName("capital");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Currency)
                .HasMaxLength(255)
                .HasColumnName("currency");
            entity.Property(e => e.CurrencyName)
                .HasMaxLength(255)
                .HasColumnName("currency_name");
            entity.Property(e => e.CurrencySymbol)
                .HasMaxLength(255)
                .HasColumnName("currency_symbol");
            entity.Property(e => e.Emoji)
                .HasMaxLength(191)
                .HasColumnName("emoji");
            entity.Property(e => e.EmojiU)
                .HasMaxLength(191)
                .HasColumnName("emojiU");
            entity.Property(e => e.Flag)
                .HasDefaultValue((short)1)
                .HasColumnName("flag");
            entity.Property(e => e.Gdp).HasColumnName("gdp");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Iso2)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("iso2");
            entity.Property(e => e.Iso3)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("iso3");
            entity.Property(e => e.Latitude)
                .HasPrecision(10, 8)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasPrecision(11, 8)
                .HasColumnName("longitude");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Nationality)
                .HasMaxLength(255)
                .HasColumnName("nationality");
            entity.Property(e => e.Native)
                .HasMaxLength(255)
                .HasColumnName("native");
            entity.Property(e => e.NumericCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("numeric_code");
            entity.Property(e => e.Phonecode)
                .HasMaxLength(255)
                .HasColumnName("phonecode");
            entity.Property(e => e.Population).HasColumnName("population");
            entity.Property(e => e.Region)
                .HasMaxLength(255)
                .HasColumnName("region");
            entity.Property(e => e.RegionId).HasColumnName("region_id");
            entity.Property(e => e.Subregion)
                .HasMaxLength(255)
                .HasColumnName("subregion");
            entity.Property(e => e.SubregionId).HasColumnName("subregion_id");
            entity.Property(e => e.Timezones).HasColumnName("timezones");
            entity.Property(e => e.Tld)
                .HasMaxLength(255)
                .HasColumnName("tld");
            entity.Property(e => e.Translations).HasColumnName("translations");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.WikiDataId)
                .HasMaxLength(255)
                .HasColumnName("wikiDataId");
        });

        modelBuilder.Entity<CourierBreak>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("courier_breaks_pkey");

            entity.ToTable("courier_breaks");

            entity.HasIndex(e => new { e.DriverId, e.BreakDate }, "courier_breaks_driver_id_break_date_key").IsUnique();

            entity.HasIndex(e => new { e.DriverId, e.BreakDate }, "idx_courier_breaks_driver_date");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.BreakDate).HasColumnName("break_date");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DriverId).HasColumnName("driver_id");
            entity.Property(e => e.TotalBreakMinutes)
                .HasDefaultValue(0)
                .HasColumnName("total_break_minutes");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Driver).WithMany(p => p.CourierBreaks)
                .HasForeignKey(d => d.DriverId)
                .HasConstraintName("courier_breaks_driver_id_fkey");
        });

        modelBuilder.Entity<CourierBreakSession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("courier_break_sessions_pkey");

            entity.ToTable("courier_break_sessions");

            entity.HasIndex(e => new { e.DriverId, e.EndedAt }, "idx_courier_break_sessions_active").HasFilter("(ended_at IS NULL)");

            entity.HasIndex(e => e.BreakId, "idx_courier_break_sessions_break_id");

            entity.HasIndex(e => e.DriverId, "idx_courier_break_sessions_driver");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.BreakId).HasColumnName("break_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DriverId).HasColumnName("driver_id");
            entity.Property(e => e.DurationMinutes).HasColumnName("duration_minutes");
            entity.Property(e => e.EndedAt).HasColumnName("ended_at");
            entity.Property(e => e.StartedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("started_at");

            entity.HasOne(d => d.Break).WithMany(p => p.CourierBreakSessions)
                .HasForeignKey(d => d.BreakId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("courier_break_sessions_break_id_fkey");

            entity.HasOne(d => d.Driver).WithMany(p => p.CourierBreakSessions)
                .HasForeignKey(d => d.DriverId)
                .HasConstraintName("courier_break_sessions_driver_id_fkey");
        });

        modelBuilder.Entity<CourierBreakSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("courier_break_settings_pkey");

            entity.ToTable("courier_break_settings");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DailyBreakMinutes)
                .HasDefaultValue(60)
                .HasColumnName("daily_break_minutes");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CourierDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("courier_documents_pkey");

            entity.ToTable("courier_documents");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.FileId).HasColumnName("file_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.File).WithMany(p => p.CourierDocuments)
                .HasForeignKey(d => d.FileId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("courier_documents_file_id_fkey");
        });

        modelBuilder.Entity<CourierOrdersLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("courier_orders_log_pkey");

            entity.ToTable("courier_orders_log");

            entity.HasIndex(e => new { e.CourierId, e.OrderId }, "courier_orders_log_courier_id_order_id_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CourierId).HasColumnName("courier_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.TriggerSource)
                .HasMaxLength(20)
                .HasDefaultValueSql("'touch_ui'::character varying")
                .HasColumnName("trigger_source");

            entity.HasOne(d => d.Courier).WithMany(p => p.CourierOrdersLogs)
                .HasForeignKey(d => d.CourierId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("courier_orders_log_courier_id_fkey");

            entity.HasOne(d => d.Order).WithMany(p => p.CourierOrdersLogs)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("courier_orders_log_order_id_fkey");
        });

        modelBuilder.Entity<CourierPackage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("courier_packages_pkey");

            entity.ToTable("courier_packages");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.DurationDays).HasColumnName("duration_days");
            entity.Property(e => e.PackageName)
                .HasMaxLength(100)
                .HasColumnName("package_name");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
        });

        modelBuilder.Entity<CourierPackageSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("courier_package_subscriptions_pkey");

            entity.ToTable("courier_package_subscriptions");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CourierId).HasColumnName("courier_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");

            entity.HasOne(d => d.Courier).WithMany(p => p.CourierPackageSubscriptions)
                .HasForeignKey(d => d.CourierId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("courier_package_subscriptions_courier_id_fkey");

            entity.HasOne(d => d.Package).WithMany(p => p.CourierPackageSubscriptions)
                .HasForeignKey(d => d.PackageId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("courier_package_subscriptions_package_id_fkey");
        });

        modelBuilder.Entity<CourierRating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("courier_ratings_pkey");

            entity.ToTable("courier_ratings");

            entity.HasIndex(e => new { e.RestaurantId, e.OrderId }, "courier_ratings_restaurant_id_order_id_key").IsUnique();

            entity.HasIndex(e => e.CourierId, "idx_courier_ratings_courier_id");

            entity.HasIndex(e => e.CreatedAt, "idx_courier_ratings_created_at");

            entity.HasIndex(e => e.OrderId, "idx_courier_ratings_order_id");

            entity.HasIndex(e => e.Rating, "idx_courier_ratings_rating");

            entity.HasIndex(e => e.RestaurantId, "idx_courier_ratings_restaurant_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Comment).HasColumnName("comment");
            entity.Property(e => e.CourierId).HasColumnName("courier_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Courier).WithMany(p => p.CourierRatings)
                .HasForeignKey(d => d.CourierId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("courier_ratings_courier_id_fkey");

            entity.HasOne(d => d.Order).WithMany(p => p.CourierRatings)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("courier_ratings_order_id_fkey");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.CourierRatings)
                .HasForeignKey(d => d.RestaurantId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("courier_ratings_restaurant_id_fkey");
        });

        modelBuilder.Entity<CourierSubscriptionRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("courier_subscription_requests_pkey");

            entity.ToTable("courier_subscription_requests");

            entity.HasIndex(e => e.MerchantOid, "courier_subscription_requests_merchant_oid_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CourierId).HasColumnName("courier_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Iscarrier)
                .HasDefaultValue(false)
                .HasColumnName("iscarrier");
            entity.Property(e => e.MerchantOid).HasColumnName("merchant_oid");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.PaymentStatus)
                .HasDefaultValueSql("'pending'::text")
                .HasColumnName("payment_status");
            entity.Property(e => e.StartDate).HasColumnName("start_date");

            entity.HasOne(d => d.Courier).WithMany(p => p.CourierSubscriptionRequests)
                .HasForeignKey(d => d.CourierId)
                .HasConstraintName("courier_subscription_requests_courier_id_fkey");

            entity.HasOne(d => d.Package).WithMany(p => p.CourierSubscriptionRequests)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("courier_subscription_requests_package_id_fkey");
        });

        modelBuilder.Entity<Dealer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dealers_pkey");

            entity.ToTable("dealers");

            entity.HasIndex(e => e.Email, "dealers_email_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.AccountType)
                .HasMaxLength(20)
                .HasColumnName("account_type");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.CommissionDescription).HasColumnName("commission_description");
            entity.Property(e => e.CommissionRate)
                .HasPrecision(5, 2)
                .HasColumnName("commission_rate");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deleted_at");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Iban)
                .HasMaxLength(34)
                .HasColumnName("iban");
            entity.Property(e => e.Latitude)
                .HasPrecision(9, 6)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasPrecision(9, 6)
                .HasColumnName("longitude");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.Resume).HasColumnName("resume");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .HasDefaultValueSql("'pendingApproval'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .HasColumnName("surname");
            entity.Property(e => e.TaxNumber)
                .HasMaxLength(20)
                .HasColumnName("tax_number");
            entity.Property(e => e.TaxOffice)
                .HasMaxLength(100)
                .HasColumnName("tax_office");
        });

        modelBuilder.Entity<DealerCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dealer_companies_pkey");

            entity.ToTable("dealer_companies");

            entity.HasIndex(e => e.CompanyId, "dealer_companies_company_id_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DealerId).HasColumnName("dealer_id");

            entity.HasOne(d => d.Company).WithOne(p => p.DealerCompany)
                .HasForeignKey<DealerCompany>(d => d.CompanyId)
                .HasConstraintName("dealer_companies_company_id_fkey");

            entity.HasOne(d => d.Dealer).WithMany(p => p.DealerCompanies)
                .HasForeignKey(d => d.DealerId)
                .HasConstraintName("dealer_companies_dealer_id_fkey");
        });

        modelBuilder.Entity<DealerCompany1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dealer_company_pkey");

            entity.ToTable("dealer_company");

            entity.HasIndex(e => new { e.DealerId, e.CompanyId }, "dealer_company_dealer_id_company_id_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DealerId).HasColumnName("dealer_id");

            entity.HasOne(d => d.Company).WithMany(p => p.DealerCompany1s)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("dealer_company_company_id_fkey");

            entity.HasOne(d => d.Dealer).WithMany(p => p.DealerCompany1s)
                .HasForeignKey(d => d.DealerId)
                .HasConstraintName("dealer_company_dealer_id_fkey");
        });

        modelBuilder.Entity<DealerFormMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dealer_form_messages_pkey");

            entity.ToTable("dealer_form_messages");

            entity.HasIndex(e => e.Status, "idx_dealer_form_messages_status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'pending'::text")
                .HasColumnName("status");
            entity.Property(e => e.Subject).HasColumnName("subject");
        });

        modelBuilder.Entity<DealerRestaurant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dealer_restaurants_pkey");

            entity.ToTable("dealer_restaurants");

            entity.HasIndex(e => new { e.DealerId, e.RestaurantId }, "dealer_restaurants_dealer_id_restaurant_id_key").IsUnique();

            entity.HasIndex(e => e.DealerId, "idx_dealer_restaurants_dealer_id");

            entity.HasIndex(e => e.RestaurantId, "idx_dealer_restaurants_restaurant_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DealerId).HasColumnName("dealer_id");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");

            entity.HasOne(d => d.Dealer).WithMany(p => p.DealerRestaurants)
                .HasForeignKey(d => d.DealerId)
                .HasConstraintName("dealer_restaurants_dealer_id_fkey");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.DealerRestaurants)
                .HasForeignKey(d => d.RestaurantId)
                .HasConstraintName("dealer_restaurants_restaurant_id_fkey");
        });

        modelBuilder.Entity<DeviceToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("device_tokens_pkey");

            entity.ToTable("device_tokens");

            entity.HasIndex(e => e.Token, "device_tokens_token_key").IsUnique();

            entity.HasIndex(e => new { e.TargetType, e.TargetId }, "idx_device_tokens_target");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.TargetId).HasColumnName("target_id");
            entity.Property(e => e.TargetType).HasColumnName("target_type");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("documents_pkey");

            entity.ToTable("documents");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.DriverId).HasColumnName("driver_id");
            entity.Property(e => e.FileUrl).HasColumnName("file_url");
            entity.Property(e => e.UploadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("uploaded_at");
        });

        modelBuilder.Entity<Driver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("drivers_pkey");

            entity.ToTable("drivers");

            entity.HasIndex(e => e.Email, "drivers_email_key").IsUnique();

            entity.HasIndex(e => e.Phone, "drivers_phone_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.About).HasColumnName("about");
            entity.Property(e => e.AverageRating)
                .HasPrecision(3, 2)
                .HasDefaultValue(0.0m)
                .HasColumnName("average_rating");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.CompanyAddress).HasColumnName("company_address");
            entity.Property(e => e.CompanyName).HasColumnName("company_name");
            entity.Property(e => e.CompanyNumber).HasColumnName("company_number");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerServiceReference).HasColumnName("customer_service_reference");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.FullAddress).HasColumnName("full_address");
            entity.Property(e => e.Iban).HasColumnName("iban");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(false)
                .HasColumnName("is_active");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.MapPreference)
                .HasMaxLength(50)
                .HasDefaultValueSql("'google'::character varying")
                .HasColumnName("map_preference");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.ProfilePhotoFileId).HasColumnName("profile_photo_file_id");
            entity.Property(e => e.TotalDeliveries)
                .HasDefaultValue(0)
                .HasColumnName("total_deliveries");
            entity.Property(e => e.TotalRatings)
                .HasDefaultValue(0)
                .HasColumnName("total_ratings");
            entity.Property(e => e.Username).HasColumnName("username");

            entity.HasOne(d => d.ProfilePhotoFile).WithMany(p => p.Drivers)
                .HasForeignKey(d => d.ProfilePhotoFileId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("drivers_profile_photo_file_id_fkey");
        });

        modelBuilder.Entity<DriverActive>(entity =>
        {
            entity.HasKey(e => e.DriverId).HasName("driver_active_pkey");

            entity.ToTable("driver_active");

            entity.Property(e => e.DriverId)
                .ValueGeneratedNever()
                .HasColumnName("driver_id");
            entity.Property(e => e.IsOnline)
                .HasDefaultValue(false)
                .HasColumnName("is_online");
            entity.Property(e => e.LastStateChange).HasColumnName("last_state_change");
            entity.Property(e => e.OnlineSince).HasColumnName("online_since");

            entity.HasOne(d => d.Driver).WithOne(p => p.DriverActive)
                .HasForeignKey<DriverActive>(d => d.DriverId)
                .HasConstraintName("driver_active_driver_id_fkey");
        });

        modelBuilder.Entity<DriverOnboarding>(entity =>
        {
            entity.HasKey(e => e.DriverId).HasName("driver_onboarding_pkey");

            entity.ToTable("driver_onboarding");

            entity.Property(e => e.DriverId)
                .ValueGeneratedNever()
                .HasColumnName("driver_id");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.ContractConfirmed).HasColumnName("contract_confirmed");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.DealerId).HasColumnName("dealer_id");
            entity.Property(e => e.FullAddress).HasColumnName("full_address");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.Step)
                .HasDefaultValue(0)
                .HasColumnName("step");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserType).HasColumnName("user_type");
            entity.Property(e => e.VehicleCapacity).HasColumnName("vehicle_capacity");
            entity.Property(e => e.VehicleType).HasColumnName("vehicle_type");
            entity.Property(e => e.VehicleYear).HasColumnName("vehicle_year");
            entity.Property(e => e.WorkingAreaType)
                .HasDefaultValueSql("'both'::text")
                .HasColumnName("working_area_type");
            entity.Property(e => e.WorkingType).HasColumnName("working_type");
        });

        modelBuilder.Entity<DriverPresenceEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("driver_presence_events_pkey");

            entity.ToTable("driver_presence_events");

            entity.HasIndex(e => new { e.DriverId, e.AtUtc }, "idx_presence_driver_time");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.AtUtc)
                .HasDefaultValueSql("now()")
                .HasColumnName("at_utc");
            entity.Property(e => e.DriverId).HasColumnName("driver_id");
            entity.Property(e => e.IsOnline).HasColumnName("is_online");

            entity.HasOne(d => d.Driver).WithMany(p => p.DriverPresenceEvents)
                .HasForeignKey(d => d.DriverId)
                .HasConstraintName("driver_presence_events_driver_id_fkey");
        });

        modelBuilder.Entity<DriverStatus>(entity =>
        {
            entity.HasKey(e => e.DriverId).HasName("driver_status_pkey");

            entity.ToTable("driver_status");

            entity.Property(e => e.DriverId)
                .ValueGeneratedNever()
                .HasColumnName("driver_id");
            entity.Property(e => e.Online)
                .HasDefaultValue(false)
                .HasColumnName("online");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<DriverWorkTime>(entity =>
        {
            entity.HasKey(e => e.DriverId).HasName("driver_work_time_pkey");

            entity.ToTable("driver_work_time");

            entity.Property(e => e.DriverId)
                .ValueGeneratedNever()
                .HasColumnName("driver_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.TotalWorkSeconds).HasColumnName("total_work_seconds");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Driver).WithOne(p => p.DriverWorkTime)
                .HasForeignKey<DriverWorkTime>(d => d.DriverId)
                .HasConstraintName("driver_work_time_driver_id_fkey");
        });

        modelBuilder.Entity<ExtraService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("extra_services_pkey");

            entity.ToTable("extra_services");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CarrierType)
                .HasDefaultValueSql("'courier'::text")
                .HasColumnName("carrier_type");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.ServiceName).HasColumnName("service_name");
        });

        modelBuilder.Entity<File>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("files_pkey");

            entity.ToTable("files");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.DelatedAt).HasColumnName("delated_at");
            entity.Property(e => e.Filename).HasColumnName("filename");
            entity.Property(e => e.ImageUrl).HasColumnName("image_url");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(false)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.MimeType).HasColumnName("mime_type");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.UploadedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("uploaded_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<GeneralSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("general_settings_pkey");

            entity.ToTable("general_settings");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.AppName).HasColumnName("app_name");
            entity.Property(e => e.AppTitle).HasColumnName("app_title");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DailyBreakMinutes)
                .HasDefaultValue(60)
                .HasColumnName("daily_break_minutes");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Keywords).HasColumnName("keywords");
            entity.Property(e => e.LogoPath).HasColumnName("logo_path");
            entity.Property(e => e.MapEmbedCode).HasColumnName("map_embed_code");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.Whatsapp).HasColumnName("whatsapp");
        });

        modelBuilder.Entity<GpsTable>(entity =>
        {
            entity.HasKey(e => e.DriverId).HasName("gps_table_pkey");

            entity.ToTable("gps_table");

            entity.HasIndex(e => e.UpdatedAt, "idx_gps_updated_at").IsDescending();

            entity.Property(e => e.DriverId)
                .ValueGeneratedNever()
                .HasColumnName("driver_id");
            entity.Property(e => e.Latitude)
                .HasPrecision(10, 6)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasPrecision(10, 6)
                .HasColumnName("longitude");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Driver).WithOne(p => p.GpsTable)
                .HasForeignKey<GpsTable>(d => d.DriverId)
                .HasConstraintName("gps_table_driver_id_fkey");
        });

        modelBuilder.Entity<HelpMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("help_messages_pkey");

            entity.ToTable("help_messages");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Subject).HasColumnName("subject");
        });

        modelBuilder.Entity<IlanKategorileri>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ilan_kategorileri_pkey");

            entity.ToTable("ilan_kategorileri");

            entity.HasIndex(e => e.AltKategoriId, "idx_ilan_kategorileri_alt_kategori");

            entity.HasIndex(e => e.AnaKategoriId, "idx_ilan_kategorileri_ana_kategori");

            entity.HasIndex(e => e.IlanId, "idx_ilan_kategorileri_ilan_id");

            entity.HasIndex(e => new { e.IlanId, e.AnaKategoriId, e.AltKategoriId }, "ilan_kategorileri_ilan_id_ana_kategori_id_alt_kategori_id_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.AltKategoriId).HasColumnName("alt_kategori_id");
            entity.Property(e => e.AnaKategoriId).HasColumnName("ana_kategori_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.IlanId).HasColumnName("ilan_id");

            entity.HasOne(d => d.AltKategori).WithMany(p => p.IlanKategorileris)
                .HasForeignKey(d => d.AltKategoriId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ilan_kategorileri_alt_kategori_id_fkey");

            entity.HasOne(d => d.AnaKategori).WithMany(p => p.IlanKategorileris)
                .HasForeignKey(d => d.AnaKategoriId)
                .HasConstraintName("ilan_kategorileri_ana_kategori_id_fkey");

            entity.HasOne(d => d.Ilan).WithMany(p => p.IlanKategorileris)
                .HasForeignKey(d => d.IlanId)
                .HasConstraintName("ilan_kategorileri_ilan_id_fkey");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("jobs_pkey");

            entity.ToTable("jobs");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerName).HasColumnName("customer_name");
            entity.Property(e => e.CustomerPhone).HasColumnName("customer_phone");
            entity.Property(e => e.DriverId).HasColumnName("driver_id");
            entity.Property(e => e.DropAddress).HasColumnName("drop_address");
            entity.Property(e => e.PickupAddress).HasColumnName("pickup_address");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<KurumsalPackage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("kurumsal_packages_pkey");

            entity.ToTable("kurumsal_packages");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.DurationDays).HasColumnName("duration_days");
            entity.Property(e => e.IncludedKm)
                .HasDefaultValue(0)
                .HasColumnName("included_km");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.OveruseKmPrice)
                .HasPrecision(10, 2)
                .HasColumnName("overuse_km_price");
            entity.Property(e => e.PackageName)
                .HasMaxLength(100)
                .HasColumnName("package_name");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
        });

        modelBuilder.Entity<KurumsalPackageSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("kurumsal_package_subscriptions_pkey");

            entity.ToTable("kurumsal_package_subscriptions");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CorporateUserId).HasColumnName("corporate_user_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.RemainingKm)
                .HasDefaultValue(0)
                .HasColumnName("remaining_km");
            entity.Property(e => e.StartDate).HasColumnName("start_date");

            entity.HasOne(d => d.CorporateUser).WithMany(p => p.KurumsalPackageSubscriptions)
                .HasForeignKey(d => d.CorporateUserId)
                .HasConstraintName("ks_pkg_corporate");

            entity.HasOne(d => d.Package).WithMany(p => p.KurumsalPackageSubscriptions)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("kurumsal_package_subscriptions_package_id_fkey");
        });

        modelBuilder.Entity<KurumsalSubscriptionRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("kurumsal_subscription_requests_pkey");

            entity.ToTable("kurumsal_subscription_requests");

            entity.HasIndex(e => e.MerchantOid, "kurumsal_subscription_requests_merchant_oid_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CorporateUserId).HasColumnName("corporate_user_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.MerchantOid).HasColumnName("merchant_oid");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.PaymentStatus)
                .HasDefaultValueSql("'pending'::text")
                .HasColumnName("payment_status");
            entity.Property(e => e.StartDate).HasColumnName("start_date");

            entity.HasOne(d => d.CorporateUser).WithMany(p => p.KurumsalSubscriptionRequests)
                .HasForeignKey(d => d.CorporateUserId)
                .HasConstraintName("ks_req_corporate");

            entity.HasOne(d => d.Package).WithMany(p => p.KurumsalSubscriptionRequests)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("kurumsal_subscription_requests_package_id_fkey");
        });

        modelBuilder.Entity<MarketerCommission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("marketer_commissions_pkey");

            entity.ToTable("marketer_commissions");

            entity.HasIndex(e => e.PartnerId, "idx_marketer_commissions_partner_id");

            entity.HasIndex(e => e.Status, "idx_marketer_commissions_status");

            entity.HasIndex(e => e.UserId, "idx_marketer_commissions_user_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(12, 2)
                .HasColumnName("amount");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.PartnerId).HasColumnName("partner_id");
            entity.Property(e => e.SourceType).HasColumnName("source_type");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'pending'::text")
                .HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Partner).WithMany(p => p.MarketerCommissions)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("marketer_commissions_partner_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.MarketerCommissions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("marketer_commissions_user_id_fkey");
        });

        modelBuilder.Entity<MarketerCommissionRate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("marketer_commission_rates_pkey");

            entity.ToTable("marketer_commission_rates");

            entity.HasIndex(e => e.CommissionType, "marketer_commission_rates_commission_type_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CommissionType).HasColumnName("commission_type");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Rate)
                .HasPrecision(5, 2)
                .HasColumnName("rate");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<MarketerLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("marketer_locations_pkey");

            entity.ToTable("marketer_locations");

            entity.HasIndex(e => e.MarketerId, "idx_marketer_locations_marketer_id");

            entity.HasIndex(e => e.UpdatedAt, "idx_marketer_locations_updated_at");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Latitude)
                .HasPrecision(10, 6)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasPrecision(10, 6)
                .HasColumnName("longitude");
            entity.Property(e => e.MarketerId).HasColumnName("marketer_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Marketer).WithMany(p => p.MarketerLocations)
                .HasForeignKey(d => d.MarketerId)
                .HasConstraintName("marketer_locations_marketer_id_fkey");
        });

        modelBuilder.Entity<MarketerShift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("marketer_shifts_pkey");

            entity.ToTable("marketer_shifts");

            entity.HasIndex(e => e.MarketerId, "idx_marketer_shifts_marketer_id");

            entity.HasIndex(e => e.ShiftStartTime, "idx_marketer_shifts_shift_start_time");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.MarketerId).HasColumnName("marketer_id");
            entity.Property(e => e.ShiftDuration).HasColumnName("shift_duration");
            entity.Property(e => e.ShiftEndTime).HasColumnName("shift_end_time");
            entity.Property(e => e.ShiftStartTime).HasColumnName("shift_start_time");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Marketer).WithMany(p => p.MarketerShifts)
                .HasForeignKey(d => d.MarketerId)
                .HasConstraintName("marketer_shifts_marketer_id_fkey");
        });

        modelBuilder.Entity<MarketerUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("marketer_users_pkey");

            entity.ToTable("marketer_users");

            entity.HasIndex(e => e.Email, "marketer_users_email_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.PartnerId).HasColumnName("partner_id");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Partner).WithMany(p => p.MarketerUsers)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_marketer_partner");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("messages_pkey");

            entity.ToTable("messages");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.DeliveredAt).HasColumnName("delivered_at");
            entity.Property(e => e.ReadAt).HasColumnName("read_at");
            entity.Property(e => e.ReceiverId).HasColumnName("receiver_id");
            entity.Property(e => e.ReceiverType).HasColumnName("receiver_type");
            entity.Property(e => e.SenderId).HasColumnName("sender_id");
            entity.Property(e => e.SenderType).HasColumnName("sender_type");
            entity.Property(e => e.SentAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("sent_at");
        });

        modelBuilder.Entity<MessagesNew>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("messages_new_pkey");

            entity.ToTable("messages_new");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.ChatId).HasColumnName("chat_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DeliveredAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("delivered_at");
            entity.Property(e => e.IsDelivered).HasColumnName("is_delivered");
            entity.Property(e => e.IsSeen).HasColumnName("is_seen");
            entity.Property(e => e.ReceiverId)
                .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'::uuid")
                .HasColumnName("receiver_id");
            entity.Property(e => e.SeenAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("seen_at");
            entity.Property(e => e.SenderId)
                .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'::uuid")
                .HasColumnName("sender_id");
            entity.Property(e => e.Text).HasColumnName("text");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("notifications_pkey");

            entity.ToTable("notifications");

            entity.HasIndex(e => e.CreatedAt, "idx_notifications_created_at").IsDescending();

            entity.HasIndex(e => new { e.TargetType, e.TargetId }, "idx_notifications_target");

            entity.HasIndex(e => new { e.TargetType, e.TargetId, e.Seen }, "idx_notifications_unseen").HasFilter("(seen = false)");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Clickable).HasColumnName("clickable");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Delivered).HasColumnName("delivered");
            entity.Property(e => e.DeliveredAt).HasColumnName("delivered_at");
            entity.Property(e => e.LogoUri).HasColumnName("logo_uri");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.RelatedId).HasColumnName("related_id");
            entity.Property(e => e.RelatedType).HasColumnName("related_type");
            entity.Property(e => e.Seen).HasColumnName("seen");
            entity.Property(e => e.SeenAt).HasColumnName("seen_at");
            entity.Property(e => e.TargetId).HasColumnName("target_id");
            entity.Property(e => e.TargetType).HasColumnName("target_type");
            entity.Property(e => e.Title).HasColumnName("title");
        });

        modelBuilder.Entity<OnboardingCorporate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("onboarding_corporate_pkey");

            entity.ToTable("onboarding_corporate");

            entity.HasIndex(e => e.Status, "idx_onboarding_corporate_status");

            entity.HasIndex(e => e.UserId, "idx_onboarding_corporate_user_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.AdminNotes).HasColumnName("admin_notes");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.FileId).HasColumnName("file_id");
            entity.Property(e => e.RejectionReason).HasColumnName("rejection_reason");
            entity.Property(e => e.ReviewedAt).HasColumnName("reviewed_at");
            entity.Property(e => e.ReviewedBy).HasColumnName("reviewed_by");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'pending'::text")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.File).WithMany(p => p.OnboardingCorporates)
                .HasForeignKey(d => d.FileId)
                .HasConstraintName("onboarding_corporate_file_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.OnboardingCorporates)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("onboarding_corporate_user_id_fkey");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_pkey");

            entity.ToTable("orders");

            entity.HasIndex(e => e.Code, "idx_orders_code");

            entity.HasIndex(e => e.CourierId, "idx_orders_courier_id");

            entity.HasIndex(e => e.CreatedAt, "idx_orders_created_at");

            entity.HasIndex(e => e.RestaurantId, "idx_orders_restaurant_id");

            entity.HasIndex(e => e.Code, "orders_code_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Amount)
                .HasPrecision(10, 2)
                .HasColumnName("amount");
            entity.Property(e => e.CargoType).HasColumnName("cargo_type");
            entity.Property(e => e.CarrierType)
                .HasDefaultValueSql("'kurye'::text")
                .HasColumnName("carrier_type");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.CourierId).HasColumnName("courier_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Customer).HasColumnName("customer");
            entity.Property(e => e.DeliveryAddress).HasColumnName("delivery_address");
            entity.Property(e => e.DropoffLat)
                .HasPrecision(9, 6)
                .HasColumnName("dropoff_lat");
            entity.Property(e => e.DropoffLng)
                .HasPrecision(9, 6)
                .HasColumnName("dropoff_lng");
            entity.Property(e => e.PackageConsumed)
                .HasPrecision(5, 2)
                .HasDefaultValue(0m)
                .HasColumnName("package_consumed");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.PickupLat)
                .HasPrecision(9, 6)
                .HasColumnName("pickup_lat");
            entity.Property(e => e.PickupLng)
                .HasPrecision(9, 6)
                .HasColumnName("pickup_lng");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");
            entity.Property(e => e.SpecialRequests).HasColumnName("special_requests");
            entity.Property(e => e.TriggerSource)
                .HasMaxLength(20)
                .HasDefaultValueSql("'touch_ui'::character varying")
                .HasColumnName("trigger_source");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.VehicleType).HasColumnName("vehicle_type");

            entity.HasOne(d => d.Courier).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CourierId)
                .HasConstraintName("orders_courier_id_fkey");

            entity.HasOne(d => d.VehicleTypeNavigation).WithMany(p => p.Orders)
                .HasPrincipalKey(p => p.Type)
                .HasForeignKey(d => d.VehicleType)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("orders_vehicle_type_fkey");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_items_pkey");

            entity.ToTable("order_items");

            entity.HasIndex(e => e.OrderId, "idx_order_items_order_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.ProductName).HasColumnName("product_name");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Total)
                .HasPrecision(10, 2)
                .HasColumnName("total");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("order_items_order_id_fkey");
        });

        modelBuilder.Entity<OrderWatcher>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("order_watchers_pkey");

            entity.ToTable("order_watchers");

            entity.HasIndex(e => e.Closed, "idx_order_watchers_closed");

            entity.HasIndex(e => new { e.RestaurantId, e.Closed }, "idx_order_watchers_restaurant_closed");

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("order_id");
            entity.Property(e => e.AvalibleDrivers).HasColumnName("avalible_drivers");
            entity.Property(e => e.Closed)
                .HasDefaultValue(false)
                .HasColumnName("closed");
            entity.Property(e => e.LastCheck).HasColumnName("last_check");
            entity.Property(e => e.RejectedDrivers).HasColumnName("rejected_drivers");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");

            entity.HasOne(d => d.Order).WithOne(p => p.OrderWatcher)
                .HasForeignKey<OrderWatcher>(d => d.OrderId)
                .HasConstraintName("order_watchers_order_id_fkey");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.OrderWatchers)
                .HasForeignKey(d => d.RestaurantId)
                .HasConstraintName("order_watchers_restaurant_id_fkey");
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("packages_pkey");

            entity.ToTable("packages");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Carrier).HasColumnName("carrier");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
        });

        modelBuilder.Entity<PartnerUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("partner_users_pkey");

            entity.ToTable("partner_users");

            entity.HasIndex(e => e.Email, "partner_users_email_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<PasswordResetToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("password_reset_tokens_pkey");

            entity.ToTable("password_reset_tokens");

            entity.HasIndex(e => e.VerificationCode, "idx_password_reset_code");

            entity.HasIndex(e => e.Email, "idx_password_reset_email");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.ExpiresAt).HasColumnName("expires_at");
            entity.Property(e => e.IpAddress).HasColumnName("ip_address");
            entity.Property(e => e.UsedAt).HasColumnName("used_at");
            entity.Property(e => e.UserType).HasColumnName("user_type");
            entity.Property(e => e.VerificationCode).HasColumnName("verification_code");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payments_pkey");

            entity.ToTable("payments");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(10, 2)
                .HasColumnName("amount");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'pending'::text")
                .HasColumnName("status");

            entity.HasOne(d => d.Job).WithMany(p => p.Payments)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("payments_job_id_fkey");
        });

        modelBuilder.Entity<Picture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pictures_pkey");

            entity.ToTable("pictures");

            entity.HasIndex(e => e.CreatedAt, "idx_pictures_created_at").IsDescending();

            entity.HasIndex(e => new { e.UserType, e.UserId }, "idx_pictures_user");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Url).HasColumnName("url");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserType).HasColumnName("user_type");
        });

        modelBuilder.Entity<PoolOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pool_orders");

            entity.HasIndex(e => e.OrderId, "pool_orders_order_id_key").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.OrderId).HasColumnName("order_id");

            entity.HasOne(d => d.Order).WithOne()
                .HasForeignKey<PoolOrder>(d => d.OrderId)
                .HasConstraintName("pool_orders_order_id_fkey");
        });

        modelBuilder.Entity<RefreshToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("refresh_tokens_pkey");

            entity.ToTable("refresh_tokens");

            entity.HasIndex(e => e.Token, "idx_refresh_tokens_token");

            entity.HasIndex(e => new { e.UserId, e.UserType }, "idx_refresh_tokens_user");

            entity.HasIndex(e => e.Token, "refresh_tokens_token_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.ExpiresAt).HasColumnName("expires_at");
            entity.Property(e => e.RevokedAt).HasColumnName("revoked_at");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserType).HasColumnName("user_type");
        });

        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("restaurants_pkey");

            entity.ToTable("restaurants");

            entity.HasIndex(e => e.Email, "restaurants_email_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.AddressLine1).HasColumnName("address_line1");
            entity.Property(e => e.AddressLine2).HasColumnName("address_line2");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.ClosingHour).HasColumnName("closing_hour");
            entity.Property(e => e.ContactPerson).HasColumnName("contact_person");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Latitude)
                .HasPrecision(9, 6)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasPrecision(9, 6)
                .HasColumnName("longitude");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.OpeningHour).HasColumnName("opening_hour");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.StateId).HasColumnName("state_id");
            entity.Property(e => e.TaxNumber).HasColumnName("tax_number");
        });

        modelBuilder.Entity<RestaurantCourier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("restaurant_couriers_pkey");

            entity.ToTable("restaurant_couriers");

            entity.HasIndex(e => e.CourierId, "idx_restaurant_couriers_courier_id");

            entity.HasIndex(e => e.RestaurantId, "idx_restaurant_couriers_restaurant_id");

            entity.HasIndex(e => new { e.RestaurantId, e.CourierId }, "restaurant_couriers_restaurant_id_courier_id_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.AssignedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("assigned_at");
            entity.Property(e => e.CourierId).HasColumnName("courier_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");

            entity.HasOne(d => d.Courier).WithMany(p => p.RestaurantCouriers)
                .HasForeignKey(d => d.CourierId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("restaurant_couriers_courier_id_fkey");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.RestaurantCouriers)
                .HasForeignKey(d => d.RestaurantId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("restaurant_couriers_restaurant_id_fkey");
        });

        modelBuilder.Entity<RestaurantMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("restaurant_menus_pkey");

            entity.ToTable("restaurant_menus");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.ImageUrl).HasColumnName("image_url");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.RestaurantMenus)
                .HasForeignKey(d => d.RestaurantId)
                .HasConstraintName("restaurant_menus_restaurant_id_fkey");
        });

        modelBuilder.Entity<RestaurantPackagePrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("restaurant_package_prices_pkey");

            entity.ToTable("restaurant_package_prices");

            entity.HasIndex(e => e.RestaurantId, "restaurant_package_prices_restaurant_id_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.MaxPackage)
                .HasDefaultValue(0)
                .HasColumnName("max_package");
            entity.Property(e => e.MinPackage)
                .HasDefaultValue(0)
                .HasColumnName("min_package");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");
            entity.Property(e => e.UnitPrice)
                .HasPrecision(10, 2)
                .HasColumnName("unit_price");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Restaurant).WithOne(p => p.RestaurantPackagePrice)
                .HasForeignKey<RestaurantPackagePrice>(d => d.RestaurantId)
                .HasConstraintName("restaurant_package_prices_restaurant_id_fkey");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.HasIndex(e => e.Name, "roles_name_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sales_pkey");

            entity.ToTable("sales");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(12, 2)
                .HasColumnName("amount");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.Lat).HasColumnName("lat");
            entity.Property(e => e.Long).HasColumnName("long");
            entity.Property(e => e.PaymentMethod).HasColumnName("payment_method");
            entity.Property(e => e.ProductType).HasColumnName("product_type");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Sales)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("sales_user_id_fkey");
        });

        modelBuilder.Entity<SiteContactMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("site_contact_messages_pkey");

            entity.ToTable("site_contact_messages");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Subject).HasColumnName("subject");
            entity.Property(e => e.TermsAccepted).HasColumnName("terms_accepted");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("states");

            entity.HasIndex(e => e.CountryId, "idx_states_country_id");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("country_code");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FipsCode)
                .HasMaxLength(255)
                .HasColumnName("fips_code");
            entity.Property(e => e.Flag)
                .HasDefaultValue((short)1)
                .HasColumnName("flag");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Iso2)
                .HasMaxLength(255)
                .HasColumnName("iso2");
            entity.Property(e => e.Iso31662)
                .HasMaxLength(10)
                .HasColumnName("iso3166_2");
            entity.Property(e => e.Latitude)
                .HasPrecision(10, 8)
                .HasColumnName("latitude");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Longitude)
                .HasPrecision(11, 8)
                .HasColumnName("longitude");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Native)
                .HasMaxLength(255)
                .HasColumnName("native");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Timezone)
                .HasMaxLength(255)
                .HasColumnName("timezone");
            entity.Property(e => e.Type)
                .HasMaxLength(191)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.WikiDataId)
                .HasMaxLength(255)
                .HasColumnName("wikiDataId");
        });

        modelBuilder.Entity<Subsection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("subsections_pkey");

            entity.ToTable("subsections");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.ShowInFooter)
                .HasDefaultValue(false)
                .HasColumnName("show_in_footer");
            entity.Property(e => e.ShowInMenu)
                .HasDefaultValue(false)
                .HasColumnName("show_in_menu");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<SupportTicket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("support_tickets_pkey");

            entity.ToTable("support_tickets");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.RepliedAt).HasColumnName("replied_at");
            entity.Property(e => e.Reply).HasColumnName("reply");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");
            entity.Property(e => e.RestaurantName).HasColumnName("restaurant_name");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'pending'::text")
                .HasColumnName("status");
            entity.Property(e => e.Subject).HasColumnName("subject");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.SupportTickets)
                .HasForeignKey(d => d.RestaurantId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("support_tickets_restaurant_id_fkey");
        });

        modelBuilder.Entity<SupportTicketsCourier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("support_tickets_courier_pkey");

            entity.ToTable("support_tickets_courier");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CourierId).HasColumnName("courier_id");
            entity.Property(e => e.CourierName).HasColumnName("courier_name");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.RepliedAt).HasColumnName("replied_at");
            entity.Property(e => e.Reply).HasColumnName("reply");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'pending'::text")
                .HasColumnName("status");
            entity.Property(e => e.Subject).HasColumnName("subject");

            entity.HasOne(d => d.Courier).WithMany(p => p.SupportTicketsCouriers)
                .HasForeignKey(d => d.CourierId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("support_tickets_courier_courier_id_fkey");
        });

        modelBuilder.Entity<SupportUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("support_users_pkey");

            entity.ToTable("support_users");

            entity.HasIndex(e => e.Email, "support_users_email_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValueSql("ARRAY[]::integer[]")
                .HasColumnName("access");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<SystemAdmin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("system_admins_pkey");

            entity.ToTable("system_admins");

            entity.HasIndex(e => e.Email, "system_admins_email_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
        });

        modelBuilder.Entity<TicarimAltKategoriler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ticarim_alt_kategoriler_pkey");

            entity.ToTable("ticarim_alt_kategoriler");

            entity.HasIndex(e => e.Aktif, "idx_ticarim_alt_kategoriler_aktif");

            entity.HasIndex(e => e.AnaKategoriId, "idx_ticarim_alt_kategoriler_ana_kategori");

            entity.HasIndex(e => new { e.AnaKategoriId, e.KategoriAdi }, "ticarim_alt_kategoriler_ana_kategori_id_kategori_adi_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.Aktif)
                .HasDefaultValue(true)
                .HasColumnName("aktif");
            entity.Property(e => e.AnaKategoriId).HasColumnName("ana_kategori_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.KategoriAdi)
                .HasMaxLength(100)
                .HasColumnName("kategori_adi");
            entity.Property(e => e.SiraNo)
                .HasDefaultValue(0)
                .HasColumnName("sira_no");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.AnaKategori).WithMany(p => p.TicarimAltKategorilers)
                .HasForeignKey(d => d.AnaKategoriId)
                .HasConstraintName("ticarim_alt_kategoriler_ana_kategori_id_fkey");
        });

        modelBuilder.Entity<TicarimAnaKategoriler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ticarim_ana_kategoriler_pkey");

            entity.ToTable("ticarim_ana_kategoriler");

            entity.HasIndex(e => e.Aktif, "idx_ticarim_ana_kategoriler_aktif");

            entity.HasIndex(e => e.SiraNo, "idx_ticarim_ana_kategoriler_sira");

            entity.HasIndex(e => e.KategoriAdi, "ticarim_ana_kategoriler_kategori_adi_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.Aktif)
                .HasDefaultValue(true)
                .HasColumnName("aktif");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.KategoriAdi)
                .HasMaxLength(100)
                .HasColumnName("kategori_adi");
            entity.Property(e => e.SiraNo)
                .HasDefaultValue(0)
                .HasColumnName("sira_no");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.HasIndex(e => e.ProfilePhotoId, "idx_users_profile_photo");

            entity.HasIndex(e => e.RoleId, "idx_users_role_id");

            entity.HasIndex(e => e.Email, "users_email_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.MapPreference)
                .HasMaxLength(50)
                .HasDefaultValueSql("'google'::character varying")
                .HasColumnName("map_preference");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.ProfilePhotoId).HasColumnName("profile_photo_id");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.ProfilePhoto).WithMany(p => p.Users)
                .HasForeignKey(d => d.ProfilePhotoId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("users_profile_photo_id_fkey");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("users_role_id_fkey");
        });

        modelBuilder.Entity<UserAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_addresses_pkey");

            entity.ToTable("user_addresses");

            entity.HasIndex(e => e.CreatedAt, "idx_user_addresses_created_at").IsDescending();

            entity.HasIndex(e => e.UserId, "idx_user_addresses_user_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Bina).HasColumnName("bina");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DaireNo).HasColumnName("daire_no");
            entity.Property(e => e.District).HasColumnName("district");
            entity.Property(e => e.Kat).HasColumnName("kat");
            entity.Property(e => e.Latitude)
                .HasPrecision(9, 6)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasPrecision(9, 6)
                .HasColumnName("longitude");
            entity.Property(e => e.Mahalle).HasColumnName("mahalle");
            entity.Property(e => e.Sokak).HasColumnName("sokak");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.UserAddresses)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("user_addresses_user_id_fkey");
        });

        modelBuilder.Entity<UserJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_jobs_pkey");

            entity.ToTable("user_jobs");

            entity.HasIndex(e => e.AssignedCourierId, "idx_user_jobs_assigned_courier_id");

            entity.HasIndex(e => e.CreatedAt, "idx_user_jobs_created_at");

            entity.HasIndex(e => e.DeliveryType, "idx_user_jobs_delivery_type");

            entity.HasIndex(e => e.JobStatus, "idx_user_jobs_job_status");

            entity.HasIndex(e => e.UserId, "idx_user_jobs_user_id");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.AssignedAt).HasColumnName("assigned_at");
            entity.Property(e => e.AssignedCourierId).HasColumnName("assigned_courier_id");
            entity.Property(e => e.CampaignCode).HasColumnName("campaign_code");
            entity.Property(e => e.CarrierType).HasColumnName("carrier_type");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.CurrentRadiusTier)
                .HasDefaultValue(1)
                .HasColumnName("current_radius_tier");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.DeliveryDate).HasColumnName("delivery_date");
            entity.Property(e => e.DeliveryTime).HasColumnName("delivery_time");
            entity.Property(e => e.DeliveryType).HasColumnName("delivery_type");
            entity.Property(e => e.DropoffAddress).HasColumnName("dropoff_address");
            entity.Property(e => e.DropoffCoordinates)
                .HasColumnType("jsonb")
                .HasColumnName("dropoff_coordinates");
            entity.Property(e => e.ExtraServices)
                .HasColumnType("jsonb")
                .HasColumnName("extra_services");
            entity.Property(e => e.ExtraServicesTotal)
                .HasDefaultValue(0m)
                .HasColumnName("extra_services_total");
            entity.Property(e => e.ImageFileIds)
                .HasDefaultValueSql("'[]'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("image_file_ids");
            entity.Property(e => e.JobStatus)
                .HasDefaultValueSql("'pending'::text")
                .HasColumnName("job_status");
            entity.Property(e => e.LastOfferSentAt).HasColumnName("last_offer_sent_at");
            entity.Property(e => e.PaymentMethod).HasColumnName("payment_method");
            entity.Property(e => e.PickupAddress).HasColumnName("pickup_address");
            entity.Property(e => e.PickupCoordinates)
                .HasColumnType("jsonb")
                .HasColumnName("pickup_coordinates");
            entity.Property(e => e.SpecialNotes).HasColumnName("special_notes");
            entity.Property(e => e.TotalPrice).HasColumnName("total_price");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VehicleProductId).HasColumnName("vehicle_product_id");
            entity.Property(e => e.VehicleType).HasColumnName("vehicle_type");

            entity.HasOne(d => d.AssignedCourier).WithMany(p => p.UserJobs)
                .HasForeignKey(d => d.AssignedCourierId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("user_jobs_assigned_courier_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.UserJobs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("user_jobs_user_id_fkey");

            entity.HasOne(d => d.VehicleProduct).WithMany(p => p.UserJobs)
                .HasForeignKey(d => d.VehicleProductId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("user_jobs_vehicle_product_id_fkey");

            entity.HasOne(d => d.VehicleTypeNavigation).WithMany(p => p.UserJobs)
                .HasPrincipalKey(p => p.Type)
                .HasForeignKey(d => d.VehicleType)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("user_jobs_vehicle_type_fkey");
        });

        modelBuilder.Entity<UserJobOffer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_job_offers_pkey");

            entity.ToTable("user_job_offers");

            entity.HasIndex(e => e.CourierId, "idx_user_job_offers_courier_id");

            entity.HasIndex(e => e.JobId, "idx_user_job_offers_job_id");

            entity.HasIndex(e => e.Status, "idx_user_job_offers_status");

            entity.HasIndex(e => new { e.JobId, e.CourierId }, "user_job_offers_job_id_courier_id_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CourierId).HasColumnName("courier_id");
            entity.Property(e => e.DistanceKm)
                .HasPrecision(10, 2)
                .HasColumnName("distance_km");
            entity.Property(e => e.ExpiresAt).HasColumnName("expires_at");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.RadiusTier)
                .HasDefaultValue(1)
                .HasColumnName("radius_tier");
            entity.Property(e => e.RespondedAt).HasColumnName("responded_at");
            entity.Property(e => e.SentAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("sent_at");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'pending'::text")
                .HasColumnName("status");

            entity.HasOne(d => d.Courier).WithMany(p => p.UserJobOffers)
                .HasForeignKey(d => d.CourierId)
                .HasConstraintName("user_job_offers_courier_id_fkey");

            entity.HasOne(d => d.Job).WithMany(p => p.UserJobOffers)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("user_job_offers_job_id_fkey");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vehicles_pkey");

            entity.ToTable("vehicles");

            entity.HasIndex(e => e.DriverId, "idx_vehicles_driver_id");

            entity.HasIndex(e => e.VehicleType, "idx_vehicles_vehicle_type");

            entity.HasIndex(e => e.Plate, "vehicles_plate_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DriverId).HasColumnName("driver_id");
            entity.Property(e => e.Make).HasColumnName("make");
            entity.Property(e => e.Model).HasColumnName("model");
            entity.Property(e => e.Plate).HasColumnName("plate");
            entity.Property(e => e.VehicleDetails)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("vehicle_details");
            entity.Property(e => e.VehicleType).HasColumnName("vehicle_type");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.Driver).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.DriverId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("vehicles_driver_id_fkey");

            entity.HasOne(d => d.VehicleTypeNavigation).WithMany(p => p.Vehicles)
                .HasPrincipalKey(p => p.Type)
                .HasForeignKey(d => d.VehicleType)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("vehicles_vehicle_type_fkey");

            entity.HasMany(d => d.FeatureNames).WithMany(p => p.Vehicles)
                .UsingEntity<Dictionary<string, object>>(
                    "VehicleFeaturesMap",
                    r => r.HasOne<VehicleFeature>().WithMany()
                        .HasPrincipalKey("Feature")
                        .HasForeignKey("FeatureName")
                        .HasConstraintName("vehicle_features_map_feature_name_fkey"),
                    l => l.HasOne<Vehicle>().WithMany()
                        .HasForeignKey("VehicleId")
                        .HasConstraintName("vehicle_features_map_vehicle_id_fkey"),
                    j =>
                    {
                        j.HasKey("VehicleId", "FeatureName").HasName("vehicle_features_map_pkey");
                        j.ToTable("vehicle_features_map");
                        j.IndexerProperty<Guid>("VehicleId").HasColumnName("vehicle_id");
                        j.IndexerProperty<string>("FeatureName").HasColumnName("feature_name");
                    });
        });

        modelBuilder.Entity<VehicleCapacityOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vehicle_capacity_options_pkey");

            entity.ToTable("vehicle_capacity_options");

            entity.HasIndex(e => e.VehicleProductId, "idx_vehicle_capacity_product");

            entity.HasIndex(e => new { e.VehicleProductId, e.MinWeight, e.MaxWeight }, "vehicle_capacity_options_vehicle_product_id_min_weight_max__key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Label).HasColumnName("label");
            entity.Property(e => e.MaxWeight)
                .HasPrecision(10, 2)
                .HasColumnName("max_weight");
            entity.Property(e => e.MinWeight)
                .HasPrecision(10, 2)
                .HasColumnName("min_weight");
            entity.Property(e => e.VehicleProductId).HasColumnName("vehicle_product_id");
        });

        modelBuilder.Entity<VehicleFeature>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vehicle_features_pkey");

            entity.ToTable("vehicle_features");

            entity.HasIndex(e => e.FeatureCode, "vehicle_features_feature_code_key").IsUnique();

            entity.HasIndex(e => e.Feature, "vehicle_features_feature_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Feature).HasColumnName("feature");
            entity.Property(e => e.FeatureCode)
                .HasMaxLength(45)
                .HasColumnName("feature_code");
        });

        modelBuilder.Entity<VehicleListing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vehicle_listings_pkey");

            entity.ToTable("vehicle_listings");

            entity.HasIndex(e => new { e.Brand, e.Model }, "idx_vehicle_listings_brand_model");

            entity.HasIndex(e => e.CreatedAt, "idx_vehicle_listings_created_at");

            entity.HasIndex(e => e.Location, "idx_vehicle_listings_location");

            entity.HasIndex(e => e.OwnerId, "idx_vehicle_listings_owner_id");

            entity.HasIndex(e => e.Price, "idx_vehicle_listings_price");

            entity.HasIndex(e => e.Status, "idx_vehicle_listings_status");

            entity.HasIndex(e => e.Year, "idx_vehicle_listings_year");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.AdminNotes).HasColumnName("admin_notes");
            entity.Property(e => e.BodyType)
                .HasMaxLength(20)
                .HasColumnName("body_type");
            entity.Property(e => e.Brand)
                .HasMaxLength(100)
                .HasColumnName("brand");
            entity.Property(e => e.Color)
                .HasMaxLength(30)
                .HasColumnName("color");
            entity.Property(e => e.Condition)
                .HasMaxLength(20)
                .HasColumnName("condition");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EngineSize).HasColumnName("engine_size");
            entity.Property(e => e.FuelType)
                .HasMaxLength(20)
                .HasColumnName("fuel_type");
            entity.Property(e => e.HeavyDamageRecorded)
                .HasDefaultValue(false)
                .HasColumnName("heavy_damage_recorded");
            entity.Property(e => e.IsSponsored)
                .HasDefaultValue(false)
                .HasColumnName("is_sponsored");
            entity.Property(e => e.Km).HasColumnName("km");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .HasColumnName("location");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("model");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .HasColumnName("nationality");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.OwnerType)
                .HasMaxLength(50)
                .HasColumnName("owner_type");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.Plate)
                .HasMaxLength(15)
                .HasColumnName("plate");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .HasDefaultValueSql("'user'::character varying")
                .HasColumnName("source");
            entity.Property(e => e.SponsorMeta).HasColumnName("sponsor_meta");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("'in_review'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Transmission)
                .HasMaxLength(20)
                .HasColumnName("transmission");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<VehicleListingImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vehicle_listing_images_pkey");

            entity.ToTable("vehicle_listing_images");

            entity.HasIndex(e => e.ListingId, "idx_vehicle_listing_images_listing_id");

            entity.HasIndex(e => new { e.ListingId, e.OrderIndex }, "idx_vehicle_listing_images_order");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FileId).HasColumnName("file_id");
            entity.Property(e => e.ListingId).HasColumnName("listing_id");
            entity.Property(e => e.OrderIndex)
                .HasDefaultValue(0)
                .HasColumnName("order_index");

            entity.HasOne(d => d.Listing).WithMany(p => p.VehicleListingImages)
                .HasForeignKey(d => d.ListingId)
                .HasConstraintName("vehicle_listing_images_listing_id_fkey");
        });

        modelBuilder.Entity<VehiclePhoto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vehicle_photos_pkey");

            entity.ToTable("vehicle_photos");

            entity.HasIndex(e => e.FileId, "idx_vehicle_photos_file_id");

            entity.HasIndex(e => e.VehicleId, "idx_vehicle_photos_vehicle_id");

            entity.HasIndex(e => new { e.VehicleId, e.OrderIndex }, "vehicle_photos_vehicle_id_order_index_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.FileId).HasColumnName("file_id");
            entity.Property(e => e.OrderIndex).HasColumnName("order_index");
            entity.Property(e => e.VehicleId).HasColumnName("vehicle_id");

            entity.HasOne(d => d.File).WithMany(p => p.VehiclePhotos)
                .HasForeignKey(d => d.FileId)
                .HasConstraintName("vehicle_photos_file_id_fkey");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.VehiclePhotos)
                .HasForeignKey(d => d.VehicleId)
                .HasConstraintName("vehicle_photos_vehicle_id_fkey");
        });

        modelBuilder.Entity<VehicleProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vehicle_products_pkey");

            entity.ToTable("vehicle_products");

            entity.HasIndex(e => e.IsActive, "idx_vehicle_products_active");

            entity.HasIndex(e => e.ProductCode, "idx_vehicle_products_code");

            entity.HasIndex(e => e.ProductTemplate, "idx_vehicle_products_template");

            entity.HasIndex(e => e.ProductCode, "vehicle_products_product_code_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.ProductCode).HasColumnName("product_code");
            entity.Property(e => e.ProductName).HasColumnName("product_name");
            entity.Property(e => e.ProductTemplate).HasColumnName("product_template");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.VehicleFeatures)
                .HasDefaultValueSql("'[]'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("vehicle_features");

            entity.HasOne(d => d.ProductTemplateNavigation).WithMany(p => p.VehicleProducts)
                .HasPrincipalKey(p => p.Type)
                .HasForeignKey(d => d.ProductTemplate)
                .HasConstraintName("vehicle_products_vehicle_type_fkey");
        });

        modelBuilder.Entity<VehicleType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vehicle_types_pkey");

            entity.ToTable("vehicle_types");

            entity.HasIndex(e => e.Type, "idx_vehicle_types_type");

            entity.HasIndex(e => e.TypeCode, "vehicle_types_type_code_key").IsUnique();

            entity.HasIndex(e => e.Type, "vehicle_types_type_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.TypeCode)
                .HasMaxLength(45)
                .HasColumnName("type_code");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
