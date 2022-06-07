namespace Serenity.Cinema {
    export interface PersonForm {
        FirstName: StringEditor;
        Lastname: StringEditor;
        BirthDate: DateEditor;
        BirthPlace: StringEditor;
        Gender: EnumEditor;
        Height: IntegerEditor;
        PrimaryImage: StringEditor;
        GalleryImages: StringEditor;
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
                var w1 = DateEditor;
                var w2 = EnumEditor;
                var w3 = IntegerEditor;

                Q.initFormType(PersonForm, [
                    'FirstName', w0,
                    'Lastname', w0,
                    'BirthDate', w1,
                    'BirthPlace', w0,
                    'Gender', w2,
                    'Height', w3,
                    'PrimaryImage', w0,
                    'GalleryImages', w0
                ]);
            }
        }
    }
}
