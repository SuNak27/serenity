namespace Serenity.Cinema {
    export interface MovieForm {
        Title: StringEditor;
        Description: TextAreaEditor;
        CastList: MoviecastEditor;
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
                var w2 = MoviecastEditor;
                var w3 = IntegerEditor;
                var w4 = DateEditor;
                var w5 = EnumEditor;
                var w6 = LookupEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'Description', w1,
                    'CastList', w2,
                    'Storyline', w1,
                    'Year', w3,
                    'ReleaseDate', w4,
                    'Kind', w5,
                    'Runtime', w3,
                    'GenreList', w6
                ]);
            }
        }
    }
}
