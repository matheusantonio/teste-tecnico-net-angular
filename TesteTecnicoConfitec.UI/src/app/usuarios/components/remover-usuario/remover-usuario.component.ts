import { Component, Input } from '@angular/core';
import {  } from '@angular/material';
import { MatDialogRef } from '@angular/material/dialog';

@Component({
  templateUrl: './remover-usuario.component.html',
  styleUrls: ['./remover-usuario.component.scss']
})
export class RemoverUsuarioComponent {
  constructor(public dialogRef: MatDialogRef<RemoverUsuarioComponent>) {}

}