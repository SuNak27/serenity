namespace Serenity.Cinema {
    export interface MovieGenresRow {
        MovieGenreId?: number;
        MovieId?: number;
        GenreId?: number;
    }

    export namespace MovieGenresRow {
        export const idProperty = 'MovieGenreId';
        export const localTextPrefix = 'Cinema.MovieGenres';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            MovieGenreId = "MovieGenreId",
            MovieId = "MovieId",
            GenreId = "GenreId"
        }
    }
}
