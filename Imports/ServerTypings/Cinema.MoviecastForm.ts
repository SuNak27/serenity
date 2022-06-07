namespace Serenity.Cinema {
    export interface MoviecastForm {
        MovieId: IntegerEditor;
        PersonId: IntegerEditor;
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
                var w0 = IntegerEditor;
                var w1 = StringEditor;

                Q.initFormType(MoviecastForm, [
                    'MovieId', w0,
                    'PersonId', w0,
                    'Character', w1
                ]);
            }
        }
    }
}
