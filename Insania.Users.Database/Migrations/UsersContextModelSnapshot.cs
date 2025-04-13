﻿// <auto-generated />
using System;
using Insania.Users.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Insania.Users.Database.Migrations
{
    [DbContext(typeof(UsersContext))]
    partial class UsersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("insania_users")
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Insania.Users.Entities.AccessRight", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("alias")
                        .HasComment("Псевдоним");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasComment("Наименование");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasAlternateKey("Alias");

                    b.ToTable("c_access_rights", "insania_users", t =>
                        {
                            t.HasComment("Права доступа");
                        });
                });

            modelBuilder.Entity("Insania.Users.Entities.Administrator", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<int>("HonorPoints")
                        .HasColumnType("integer")
                        .HasColumnName("honor_points")
                        .HasComment("Баллы почёта");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("boolean")
                        .HasColumnName("is_system")
                        .HasComment("Признак системной записи");

                    b.Property<long>("PositionTitleId")
                        .HasColumnType("bigint")
                        .HasColumnName("position_title_id")
                        .HasComment("Идентификатор звания должности");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id")
                        .HasComment("Идентификатор пользователя");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasIndex("PositionTitleId");

                    b.HasIndex("UserId");

                    b.ToTable("r_administrators", "insania_users", t =>
                        {
                            t.HasComment("Администраторы");
                        });
                });

            modelBuilder.Entity("Insania.Users.Entities.Chapter", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("boolean")
                        .HasColumnName("is_system")
                        .HasComment("Признак системной записи");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasComment("Наименование");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint")
                        .HasColumnName("parent_id")
                        .HasComment("Идентификатор родителя");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasAlternateKey("Name");

                    b.HasIndex("ParentId");

                    b.ToTable("r_chapters", "insania_users", t =>
                        {
                            t.HasComment("Капитулы");
                        });
                });

            modelBuilder.Entity("Insania.Users.Entities.Player", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("boolean")
                        .HasColumnName("is_system")
                        .HasComment("Признак системной записи");

                    b.Property<int>("LoyaltyPoints")
                        .HasColumnType("integer")
                        .HasColumnName("loyalty_points")
                        .HasComment("Баллы верности");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id")
                        .HasComment("Идентификатор пользователя");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("r_players", "insania_users", t =>
                        {
                            t.HasComment("Игроки");
                        });
                });

            modelBuilder.Entity("Insania.Users.Entities.Position", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("ActivityArea")
                        .HasColumnType("text")
                        .HasColumnName("activity_area")
                        .HasComment("Сфера деятельности");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("alias")
                        .HasComment("Псевдоним");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasComment("Наименование");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasAlternateKey("Alias");

                    b.ToTable("c_positions", "insania_users", t =>
                        {
                            t.HasComment("Должности");
                        });
                });

            modelBuilder.Entity("Insania.Users.Entities.PositionTitle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<long>("PositionId")
                        .HasColumnType("bigint")
                        .HasColumnName("position_id")
                        .HasComment("Идентификатор должности");

                    b.Property<long>("TitleId")
                        .HasColumnType("bigint")
                        .HasColumnName("title_id")
                        .HasComment("Идентификатор звания");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasAlternateKey("PositionId", "TitleId");

                    b.HasIndex("TitleId");

                    b.ToTable("u_positions_titles", "insania_users", t =>
                        {
                            t.HasComment("Звания должностей");
                        });
                });

            modelBuilder.Entity("Insania.Users.Entities.PositionTitleAccessRight", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AccessRightId")
                        .HasColumnType("bigint")
                        .HasColumnName("access_right_id")
                        .HasComment("Идентификатор права доступа");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<long>("PositionTitleId")
                        .HasColumnType("bigint")
                        .HasColumnName("position_title_id")
                        .HasComment("Идентификатор звания должности");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasAlternateKey("AccessRightId", "PositionTitleId");

                    b.HasIndex("PositionTitleId");

                    b.ToTable("u_positions_titles_access_rights", "insania_users", t =>
                        {
                            t.HasComment("Права доступ званий должностей");
                        });
                });

            modelBuilder.Entity("Insania.Users.Entities.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("alias")
                        .HasComment("Псевдоним");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasComment("Наименование");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasAlternateKey("Alias");

                    b.ToTable("c_roles", "insania_users", t =>
                        {
                            t.HasComment("Роли");
                        });
                });

            modelBuilder.Entity("Insania.Users.Entities.RoleAccessRight", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AccessRightId")
                        .HasColumnType("bigint")
                        .HasColumnName("access_right_id")
                        .HasComment("Идентификатор права доступа");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint")
                        .HasColumnName("role_id")
                        .HasComment("Идентификатор роли");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasAlternateKey("AccessRightId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("u_roles_access_rights", "insania_users", t =>
                        {
                            t.HasComment("Права доступ ролей");
                        });
                });

            modelBuilder.Entity("Insania.Users.Entities.Title", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("alias")
                        .HasComment("Псевдоним");

                    b.Property<double>("CoefficientAccrualHonorPoints")
                        .HasColumnType("double precision")
                        .HasColumnName("coefficient_accrual_honor_points")
                        .HasComment("Коэффициент начисления баллов почёта");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasComment("Наименование");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasAlternateKey("Alias");

                    b.ToTable("c_titles", "insania_users", t =>
                        {
                            t.HasComment("Звания");
                        });
                });

            modelBuilder.Entity("Insania.Users.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateOnly?>("BirthDate")
                        .HasColumnType("date")
                        .HasColumnName("birth_date")
                        .HasComment("Дата рождения");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email")
                        .HasComment("Электронная почта");

                    b.Property<string>("FirstName")
                        .HasColumnType("text")
                        .HasColumnName("first_name")
                        .HasComment("Имя");

                    b.Property<bool?>("Gender")
                        .HasColumnType("boolean")
                        .HasColumnName("gender")
                        .HasComment("Пол(истина - мужской/ложь - женский/null - неизвестно)");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("boolean")
                        .HasColumnName("is_blocked")
                        .HasComment("Признак блокировки пользователя");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("boolean")
                        .HasColumnName("is_system")
                        .HasComment("Признак системной записи");

                    b.Property<string>("LastName")
                        .HasColumnType("text")
                        .HasColumnName("last_name")
                        .HasComment("Фамилия");

                    b.Property<string>("LinkVK")
                        .HasColumnType("text")
                        .HasColumnName("link_vk")
                        .HasComment("Ссылка в ВК");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("login")
                        .HasComment("Логин");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password")
                        .HasComment("Пароль");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text")
                        .HasColumnName("patronymic")
                        .HasComment("Отчество");

                    b.Property<string>("Phone")
                        .HasColumnType("text")
                        .HasColumnName("phone")
                        .HasComment("Номер телефона");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasAlternateKey("Login");

                    b.ToTable("r_users", "insania_users", t =>
                        {
                            t.HasComment("Пользователи");
                        });
                });

            modelBuilder.Entity("Insania.Users.Entities.UserRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint")
                        .HasColumnName("role_id")
                        .HasComment("Идентификатор роли");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id")
                        .HasComment("Идентификатор пользователя");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasAlternateKey("RoleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("u_users_roles", "insania_users", t =>
                        {
                            t.HasComment("Роли пользователей");
                        });
                });

            modelBuilder.Entity("Insania.Users.Entities.Administrator", b =>
                {
                    b.HasOne("Insania.Users.Entities.PositionTitle", "PositionTitleEntity")
                        .WithMany()
                        .HasForeignKey("PositionTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Insania.Users.Entities.User", "UserEntity")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PositionTitleEntity");

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("Insania.Users.Entities.Chapter", b =>
                {
                    b.HasOne("Insania.Users.Entities.Chapter", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Insania.Users.Entities.Player", b =>
                {
                    b.HasOne("Insania.Users.Entities.User", "UserEntity")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("Insania.Users.Entities.PositionTitle", b =>
                {
                    b.HasOne("Insania.Users.Entities.Position", "PositionEntity")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Insania.Users.Entities.Title", "TitleEntity")
                        .WithMany()
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PositionEntity");

                    b.Navigation("TitleEntity");
                });

            modelBuilder.Entity("Insania.Users.Entities.PositionTitleAccessRight", b =>
                {
                    b.HasOne("Insania.Users.Entities.AccessRight", "AccessRightEntity")
                        .WithMany()
                        .HasForeignKey("AccessRightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Insania.Users.Entities.PositionTitle", "PositionTitleEntity")
                        .WithMany()
                        .HasForeignKey("PositionTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccessRightEntity");

                    b.Navigation("PositionTitleEntity");
                });

            modelBuilder.Entity("Insania.Users.Entities.RoleAccessRight", b =>
                {
                    b.HasOne("Insania.Users.Entities.AccessRight", "AccessRightEntity")
                        .WithMany()
                        .HasForeignKey("AccessRightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Insania.Users.Entities.Role", "RoleEntity")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccessRightEntity");

                    b.Navigation("RoleEntity");
                });

            modelBuilder.Entity("Insania.Users.Entities.UserRole", b =>
                {
                    b.HasOne("Insania.Users.Entities.Role", "RoleEntity")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Insania.Users.Entities.User", "UserEntity")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoleEntity");

                    b.Navigation("UserEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
