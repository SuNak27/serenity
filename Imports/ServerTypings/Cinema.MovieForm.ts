namespace Serenity.Cinema {
    export interface MovieForm {
        Title: StringEditor;
        Description: TextAreaEditor;
        CastList: MoviecastEditor;
        PrimaryImage: ImageUploadEditor;
        GalleryImages: MultipleImageUploadEditor;
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
                var w3 = ImageUploadEditor;
                var w4 = MultipleImageUploadEditor;
                var w5 = IntegerEditor;
                var w6 = DateEditor;
                var w7 = EnumEditor;
                var w8 = LookupEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'Description', w1,
                    'CastList', w2,
                    'PrimaryImage', w3,
                    'GalleryImages', w4,
                    'Storyline', w1,
                    'Year', w5,
                    'ReleaseDate', w6,
                    'Kind', w7,
                    'Runtime', w5,
                    'GenreList', w8
                ]);
            }
        }
    }
}
