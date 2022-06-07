namespace Serenity.Cinema {
    export interface GenreForm {
        Name: StringEditor;
    }

    export class GenreForm extends Serenity.PrefixedContext {
        static formKey = 'Cinema.Genre';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!GenreForm.init)  {
                GenreForm.init = true;

                var s = Serenity;
                var w0 = StringEditor;

                Q.initFormType(GenreForm, [
                    'Name', w0
                ]);
            }
        }
    }
}
