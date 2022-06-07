namespace Serenity.Cinema {
    export interface MoviecastForm {
        PersonId: LookupEditor;
        Character: StringEditor;
    }

    export class MoviecastForm extends Serenity.PrefixedContext {
        static formKey = 'Cinema.Moviecast';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MoviecastForm.init)  {
                MoviecastForm.init = true;

                var s = Serenity;
                var w0 = LookupEditor;
                var w1 = StringEditor;

                Q.initFormType(MoviecastForm, [
                    'PersonId', w0,
                    'Character', w1
                ]);
            }
        }
    }
}
