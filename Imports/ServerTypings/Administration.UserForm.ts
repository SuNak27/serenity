namespace Serenity.Administration {
    export interface UserForm {
        Username: StringEditor;
        DisplayName: StringEditor;
        Email: EmailEditor;
        UserImage: ImageUploadEditor;
        Password: PasswordEditor;
        PasswordConfirm: PasswordEditor;
        Source: StringEditor;
    }

    export class UserForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.User';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserForm.init)  {
                UserForm.init = true;

                var s = Serenity;
                var w0 = StringEditor;
                var w1 = EmailEditor;
                var w2 = ImageUploadEditor;
                var w3 = PasswordEditor;

                Q.initFormType(UserForm, [
                    'Username', w0,
                    'DisplayName', w0,
                    'Email', w1,
                    'UserImage', w2,
                    'Password', w3,
                    'PasswordConfirm', w3,
                    'Source', w0
                ]);
            }
        }
    }
}
