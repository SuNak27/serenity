namespace Serenity.MasterData {
    export interface KegiatanRow {
        Id?: number;
        NamaKegiatan?: string;
    }

    export namespace KegiatanRow {
        export const idProperty = 'Id';
        export const nameProperty = 'NamaKegiatan';
        export const localTextPrefix = 'MasterData.Kegiatan';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            NamaKegiatan = "NamaKegiatan"
        }
    }
}
