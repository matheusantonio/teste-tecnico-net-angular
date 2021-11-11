import { BrowserModule } from "@angular/platform-browser";
import { FormControl } from "@angular/forms";

export class UsuariosCustomValidators {

    public static dateValidator(control: FormControl) {
        if (control.value) {
          const date = new Date(control.value);
          const today = new Date();
          if (date >= today) {
            return { 'dataInvalida': true }
          }
        }
        return null;
      }

}
