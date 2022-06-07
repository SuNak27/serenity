namespace Serenity.Cinema {
    export enum CinemaKind {
        Film = 1,
        TvSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnumType(CinemaKind, 'Serenity.Cinema.CinemaKind', 'Cinema.CinemaKind');
}
