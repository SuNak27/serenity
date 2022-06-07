namespace Serenity.Cinema {
    export interface MovieForm {
        Title: StringEditor;
        Description: TextAreaEditor;
        Storyline: TextAreaEditor;
        Year: IntegerEditor;
        ReleaseDate: DateEditor;
        GenreId: LookupEditor;
        Kind: EnumEditor;
        Runtime: IntegerEditor;
    }

    export class MovieForm extends Serenity.PrefixedContext {
        static formKey = 'Cinema.Movie';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MovieForm.init)  {
                MovieForm.init = true;

                var s = Serenity;
                var w0 = StringEditor;
                var w1 = TextAreaEditor;
                var w2 = IntegerEditor;
                var w3 = DateEditor;
                var w4 = LookupEditor;
                var w5 = EnumEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'Description', w1,
                    'Storyline', w1,
                    'Year', w2,
                    'ReleaseDate', w3,
                    'GenreId', w4,
                    'Kind', w5,
                    'Runtime', w2
                ]);
            }
        }
    }
}
