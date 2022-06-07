namespace Serenity.Administration {
    export interface LanguageForm {
        LanguageId: StringEditor;
        LanguageName: StringEditor;
    }

    export class LanguageForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.Language';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!LanguageForm.init)  {
                LanguageForm.init = true;

                var s = Serenity;
                var w0 = StringEditor;

                Q.initFormType(LanguageForm, [
                    'LanguageId', w0,
                    'LanguageName', w0
                ]);
            }
        }
    }
}
