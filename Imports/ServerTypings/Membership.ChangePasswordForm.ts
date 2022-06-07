namespace Serenity.Membership {
    export interface ChangePasswordForm {
        OldPassword: PasswordEditor;
        NewPassword: PasswordEditor;
        ConfirmPassword: PasswordEditor;
    }

    export class ChangePasswordForm extends Serenity.PrefixedContext {
        static formKey = 'Membership.ChangePassword';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ChangePasswordForm.init)  {
                ChangePasswordForm.init = true;

                var s = Serenity;
                var w0 = PasswordEditor;

                Q.initFormType(ChangePasswordForm, [
                    'OldPassword', w0,
                    'NewPassword', w0,
                    'ConfirmPassword', w0
                ]);
            }
        }
    }
}
