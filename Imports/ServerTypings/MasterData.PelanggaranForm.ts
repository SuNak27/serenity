namespace Serenity.MasterData {
    export interface PelanggaranForm {
        Pelanggaran: StringEditor;
        TglPelanggaran: DateEditor;
        Keterangan: StringEditor;
    }

    export class PelanggaranForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Pelanggaran';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PelanggaranForm.init)  {
                PelanggaranForm.init = true;

                var s = Serenity;
                var w0 = StringEditor;
                var w1 = DateEditor;

                Q.initFormType(PelanggaranForm, [
                    'Pelanggaran', w0,
                    'TglPelanggaran', w1,
                    'Keterangan', w0
                ]);
            }
        }
    }
}
