namespace Serenity.MasterData {
    export interface SiswaForm {
        Nis: IntegerEditor;
        Nama: StringEditor;
        KotaAsal: StringEditor;
        TglLahir: DateEditor;
        Umur: IntegerEditor;
        DetailPelanggaran: PelanggaranDetailEditor;
    }

    export class SiswaForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Siswa';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SiswaForm.init)  {
                SiswaForm.init = true;

                var s = Serenity;
                var w0 = IntegerEditor;
                var w1 = StringEditor;
                var w2 = DateEditor;
                var w3 = PelanggaranDetailEditor;

                Q.initFormType(SiswaForm, [
                    'Nis', w0,
                    'Nama', w1,
                    'KotaAsal', w1,
                    'TglLahir', w2,
                    'Umur', w0,
                    'DetailPelanggaran', w3
                ]);
            }
        }
    }
}
