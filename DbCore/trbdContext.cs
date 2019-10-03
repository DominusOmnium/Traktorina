using System.Collections.Generic;
using System.Linq;
using DbCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MarinaIvanna
{
    public partial class trbdContext : DbContext
    {
        public trbdContext()
        {

        }
        public trbdContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public trbdContext(IConfiguration configuration, DbContextOptions<trbdContext> options)
            : base(options)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration
        {
            get; 
    }

        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<Problems> Problems { get; set; }
        public virtual DbSet<RequestStatuses> RequestStatuses { get; set; }
        public virtual DbSet<UserRequiesties> UserRequiesties { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        public virtual DbSet<ProblemLink> ProblemLinks {
            get;
            set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                return;

            var connectionString = Configuration.GetConnectionString("Db") ?? "Host=194.58.102.106;Port=5432;Database=trbd;Username=appuser;Password=RTxrHA90r2M%C0vZW6uh";
            optionsBuilder.UseNpgsql(connectionString, builder => builder.MigrationsAssembly("MarinaIvanna"));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Companies>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("companies_un")
                    .IsUnique();
            });

            modelBuilder.Entity<Problems>(entity =>
            {
                entity.HasIndex(e => e.Key)
                    .HasName("problems_un")
                    .IsUnique();
                var i = 0;
            });

            modelBuilder.Entity<RequestStatuses>(entity =>
            {
                entity.HasIndex(e => e.StatusName)
                    .HasName("requeststatuses_un")
                    .IsUnique();
            });

            modelBuilder.Entity<UserRequiesties>(entity =>
            {
                entity.HasIndex(e => e.CompanyId);

                entity.HasIndex(e => e.ProblemsId);

                entity.HasIndex(e => e.RunnerId);

                entity.HasIndex(e => e.SenderId);

                entity.HasIndex(e => e.StatusId);

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("uid")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserRequiesties)
                    .HasForeignKey(d => d.CompanyId);

                entity.HasOne(d => d.Problems)
                    .WithMany(p => p.UserRequiesties)
                    .HasForeignKey(d => d.ProblemsId);

                entity.HasOne(d => d.Runner)
                    .WithMany(p => p.UserRequiestiesRunner)
                    .HasForeignKey(d => d.RunnerId);

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.UserRequiestiesSender)
                    .HasForeignKey(d => d.SenderId);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.UserRequiesties)
                    .HasForeignKey(d => d.StatusId);
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("userroles_un")
                    .IsUnique();
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.CompanyId);

                entity.HasIndex(e => e.Login)
                    .HasName("users_un")
                    .IsUnique();

                entity.HasIndex(e => e.UserRoleId);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CompanyId);

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserRoleId);
            });
        }



        public static IDictionary<string, string> GetProblems()
        {
            return new Dictionary<string, string>()
            {
                {"1", " Холодное водоснабжение"},
                {"1__1", " Прорыв трубы"},
                {"1__2", " Течь вводного крана "},
                {"1__3", " Течь в подвал "},
                {"1__4", " Нет холодной воды "},
                {"1__5", " Течь смесителя в ванной "},
                {"1__6", " Течь смесителя на кухне "},
                {"1__7", " Срыв гибкой подводки в ванной "},
                {"1__8", " Срыв гибкой подводки на кухне "},
                {"1__9", " Срыв гибкой подводки в туалете "},
                {"1__10", " Течь бачка унитаза "},
                {"1__11", " Плохое качество воды "},
                {"1__12", " Нет напора воды на газовую колонку "},
                {"1__13", " Смена пробко-сальникового крана ХВС в подвале "},
                {"1__14", " Нет напора воды в кране ХВС "},
                {"1__15", " Течь под ванной "},
                {"1__16", " Течь с потолка "},
                {"1__17", " Подмес горячей воды в холодную"},
                {"2", " Лифт"},
                {"2__1", " Неисправный лифт"},
                {"2__2", " Вибрация кабины лифта при движении "},
                {"2__3", " Переподъем или переспуск кабины относительно этажа "},
                {"2__4", " Неисправное освещение в лифте"},
                {"2__5", " Не работают кнопки в блоке управления "},
                {"2__6", " Кабина лифта не убрана "},
                {"2__7", " Заклинило двери лифта "},
                {"2__8", " Застревание пассажира"},
                {"2__9", " Залитие шахты "},
                {"2__10", " Связь Лифт "},
                {"3", " Газовые сети"},
                {"3__01", " Прорыв газового трубопровода   "},
                {"3__02", " Прекращение подачи газа   "},
                {"3__03", " Запах газа в подъезде или у подъезда   "},
                {"3__04", " Вода в газовой трубе   "},
                {"3__05", " Повреждение крепления газопровода   "},
                {"3__06", " Запах газа в квартире или у квартиры   "},
                {"3__07", " Ремонт газовой плиты   "},
                {"3__08", " Ремонт газового котла "},
                {"3__09", " Ремонт газовой колонки   "},
                {"3__10", " Замена газовой плиты без сварочных работ   "},
                {"3__11", " Замена газовой плиты со сварочными работами   "},
                {"3__12", " Демонтаж газовой плиты с установкой заглушки   "},
                {"3__13", " Прочистка, калибровка сопла горелки плиты   "},
                {"3__14", " Чистка горелки духового шкафа   "},
                {"3__15", " Подключение газовой колонки к газопроводу без доп.работ (гофра)"},
                {
                    "3__16",
                    " Замена газовой колонки без изменения подводки с пуском газа и устройством дымоудаления (гофра)"
                },
                {
                    "3__17",
                    " Замена газовой колонки с новой подводкой водопровода, газопровода, пуском газа и устройством дымоудаления (гофра)   "
                },
                {"3__18", " Снятие, установка теплообменника колонки   "},
                {"3__19", " Чистка горелки колонки   "},
                {"3__20", " Устранение течи воды в резьбовом соединении   "},
                {"3__21", " Замена газового котла без сварочных работ   "},
                {"3__22", " Замена газового крана на опуске   "},
                {"3__23", " Диагностика и обследование газового оборудование   "},
                {"3__24", " Техническое обслуживание ВКГО"},
                {"4", " Техническое обслуживание"},
                {"4__01", " Неисправность входной двери"},
                {"4__02", " 1 Неисправность дверей переходных лоджий,лестниц"},
                {"4__03", " Замена/ремонт пружины или доводчика двери подъезда"},
                {"4__04", " Ремонт/замена домофона"},
                {"4__05", " Отстутствует остекление в подъезде/разбитые окна (зимой"},
                {"4__06", " Отсутствует остекление в подъезде/разбитые окна (летний период)"},
                {"4__07", " Отсутствуют замки на входных дверях в подвал и/или мусорокамеры"},
                {"4__08", " Неисправный мусоропровод"},
                {"4__09", " Неисправность подъемной платформы для инвалидов в подъезде"},
                {"4__10", " Не работает предъподъездное освещение"},
                {
                    "4__11",
                    " Неисправность/недоступность инфраструктуры для маломобильных граждан (установка или ремонт пандусов)"
                },
                {"4__12", " Неисправное освещение в подъезде"},
                {"4__13", " Внутриквартирное устройство"},
                {"4__14", " Магнит запирающего устройства"},
                {"4__15", " Магнитные ключи (домофон)"},
                {"4__16", " Общедомовое устройство"},
                {"4__17", " Переговорное устройство"},
                {"4__18", " Отсутствует/не работает ЗУ"},
                {"5", " Текущий ремонт"},
                {"5__01", " Осыпается потолок в подъезде"},
                {"5__02", " Ремонт или замена почтовых ящиков в подъезде"},
                {"5__03", " Ремонт подъезда"},
                {"5__04", " Ремонт перил, поручней"},
                {"5__05", " Ремонт ступеней"},
                {"5__06", " Ремонт козырька над подъездом"},
                {"5__07", " Некачественный текущий ремонт"},
                {"6", " Платные услуги"},
                {"6__01", " Замена смесителя с душем"},
                {"6__02", " Замена смесителя \"Елочка\""},
                {"6__03", " Замена полотенцесушителя"},
                {"6__04", " Замена унитаза \"Компакт\""},
                {"6__05", " Смена вентиля"},
                {"6__06", " Смена радиатора"},
                {"6__07", " Замена ванной (любой модели)"},
                {"6__08", " Смена умывальника со смесителем"},
                {"6__09", " Установка стиральной машины с подключением к системе водоснабжения"},
                {"11", " Горячее водоснабжение"},
                {"11__01", " Прорыв трубы"},
                {"11__02", " Течь вводного крана"},
                {"11__03", " Течь полотенцесушителя"},
                {"11__04", " Нет горячей воды"},
                {"11__05", " Течь смесителя в ванной"},
                {"11__06", " Течь смесителя на кухне"},
                {"11__07", " Срыв гибкой подводки в ванной"},
                {"11__08", " Срыв гибкой подводки на кухне"},
                {"11__09", " Нет напора воды в кране ГВС"},
                {"11__10", " Холодный полотенцесушитель"},
                {"12", " Электрические сети"},
                {"12__01", " Запах горелой проводки"},
                {"12__02", " Отключение электроснабжения"},
                {"12__03", " Не горит лампочка в подъезде"},
                {"12__04", " Мерцание света"},
                {"12__05", " Искрит в эл. щите"},
                {"12__06", " Искрит выключатель/розетка"},
                {"12__07", " Выбивает автомат"},
                {"12__08", " Нагреваются провода/розетка"},
                {"12__09", " Неисправности в электроплите (с отключением всей электроплиты)"},
                {"12__10", " Неисправности в электроплите (с выходом из строя одной конфорки и жарочного шкафа)"}
            };
        }
}

  
}
