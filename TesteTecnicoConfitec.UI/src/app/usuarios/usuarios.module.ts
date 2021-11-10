import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { SharedModule } from '../@shared/shared.module';
import { CardUsuarioComponent } from './components/card-usuario/card-usuario.component';
import { FormUsuarioComponent } from './components/form-usuario/form-usuario.component';
import { ListaDeUsuariosComponent } from './components/lista-de-usuarios/lista-de-usuarios.component';
import { RemoverUsuarioComponent } from './components/remover-usuario/remover-usuario.component';
import { UsuariosComponent } from './pages/usuarios.component';

@NgModule({
  imports:[
    RouterModule,
    SharedModule,
    CommonModule,
  ],
  declarations: [
      UsuariosComponent,
      CardUsuarioComponent,
      FormUsuarioComponent,
      ListaDeUsuariosComponent,
      RemoverUsuarioComponent,
  ],
  exports: [
      UsuariosComponent,
  ],
})
export class UsuariosModule { }