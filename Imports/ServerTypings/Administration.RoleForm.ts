namespace Serenity.Administration {
    export interface RoleForm {
        RoleName: StringEditor;
    }

    export class RoleForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.Role';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RoleForm.init)  {
                RoleForm.init = true;

                var s = Serenity;
                var w0 = StringEditor;

                Q.initFormType(RoleForm, [
                    'RoleName', w0
                ]);
            }
        }
    }
}
