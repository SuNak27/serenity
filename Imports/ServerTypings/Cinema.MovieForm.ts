namespace Serenity.Cinema {
    export interface MovieForm {
        Title: StringEditor;
        Description: TextAreaEditor;
        Storyline: TextAreaEditor;
        Year: IntegerEditor;
        ReleaseDate: DateEditor;
        Kind: EnumEditor;
        Runtime: IntegerEditor;
        GenreList: LookupEditor;
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
                var w4 = EnumEditor;
                var w5 = LookupEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'Description', w1,
                    'Storyline', w1,
                    'Year', w2,
                    'ReleaseDate', w3,
                    'Kind', w4,
                    'Runtime', w2,
                    'GenreList', w5
                ]);
            }
        }
    }
}
