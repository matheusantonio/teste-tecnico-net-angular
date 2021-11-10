import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { SharedModule } from '../@shared/shared.module';
import { CardUsuarioComponent } from './components/card-usuario/card-usuario.component';
import { FormUsuarioComponent } from './components/form-usuario/form-usuario.component';
import { ListaDeUsuariosComponent } from './components/lista-de-usuarios/lista-de-usuarios.component';
import { UsuariosComponent } from './pages/usuarios.component';

@NgModule({
  imports:[
    RouterModule,
    SharedModule,
  ],
  declarations: [
      UsuariosComponent,
      CardUsuarioComponent,
      FormUsuarioComponent,
      ListaDeUsuariosComponent,
  ],
  exports: [
      UsuariosComponent,
  ],
})
export class UsuariosModule { }