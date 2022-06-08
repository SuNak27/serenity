namespace Serenity.Cinema {
    export interface PersonForm {
        FirstName: StringEditor;
        Lastname: StringEditor;
        PrimaryImage: ImageUploadEditor;
        GalleryImages: MultipleImageUploadEditor;
        BirthDate: DateEditor;
        BirthPlace: StringEditor;
        Gender: EnumEditor;
        Height: IntegerEditor;
    }

    export class PersonForm extends Serenity.PrefixedContext {
        static formKey = 'Cinema.Person';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PersonForm.init)  {
                PersonForm.init = true;

                var s = Serenity;
                var w0 = StringEditor;
                var w1 = ImageUploadEditor;
                var w2 = MultipleImageUploadEditor;
                var w3 = DateEditor;
                var w4 = EnumEditor;
                var w5 = IntegerEditor;

                Q.initFormType(PersonForm, [
                    'FirstName', w0,
                    'Lastname', w0,
                    'PrimaryImage', w1,
                    'GalleryImages', w2,
                    'BirthDate', w3,
                    'BirthPlace', w0,
                    'Gender', w4,
                    'Height', w5
                ]);
            }
        }
    }
}
