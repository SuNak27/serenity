namespace Serenity.MasterData {
    export interface KegiatanForm {
        NamaKegiatan: StringEditor;
    }

    export class KegiatanForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Kegiatan';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!KegiatanForm.init)  {
                KegiatanForm.init = true;

                var s = Serenity;
                var w0 = StringEditor;

                Q.initFormType(KegiatanForm, [
                    'NamaKegiatan', w0
                ]);
            }
        }
    }
}
