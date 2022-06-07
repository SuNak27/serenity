using Serenity.Navigation;
using MyPages = Serenity.MasterData.Pages;
using MyPagesCinema = Serenity.Cinema.Pages;

[assembly: NavigationMenu(2000, "MasterData", icon: "fa-database")]
// [assembly: NavigationLink(2100, "MasterData/Pelanggaran", typeof(MyPages.PelanggaranController), icon: "fa-list-alt")]
[assembly: NavigationLink(2200, "MasterData/Siswa", typeof(MyPages.SiswaController), icon: "fa-user")]
[assembly: NavigationLink(2300, "MasterData/Kegiatan", typeof(MyPages.KegiatanController), icon: "fa-list-alt")]

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]

[assembly: NavigationMenu(3000, "Cinema", icon: "fa-ticket")]
[assembly: NavigationLink(3100, "Cinema/Movie", typeof(MyPagesCinema.MovieController), icon: "fa-film")]
[assembly: NavigationLink(4001, "Cinema/Genre", typeof(MyPagesCinema.GenreController), icon: "fa-bars")]
[assembly: NavigationLink(4200, "Cinema/Person", typeof(MyPagesCinema.PersonController), icon: "fa-user")]
[assembly: NavigationLink(4300, "Cinema/Moviecast", typeof(MyPagesCinema.MoviecastController), icon: "fa-users")]