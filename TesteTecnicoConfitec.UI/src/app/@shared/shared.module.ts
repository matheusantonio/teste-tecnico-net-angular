import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatToolbarModule } from '@angular/material/toolbar';
import {MatDividerModule} from '@angular/material/divider'; 
import {MatFormFieldModule} from '@angular/material/form-field'; 
import { MatInputModule } from '@angular/material/input';
import {MatDatepickerModule} from '@angular/material/datepicker'; 
import {MatSelectModule} from '@angular/material/select'; 
import { ReactiveFormsModule } from '@angular/forms';
import { MatNativeDateModule } from '@angular/material/core';
import {MatSnackBarModule} from '@angular/material/snack-bar'; 
import {MatButtonModule} from '@angular/material/button'; 

@NgModule({
  imports:[
    HttpClientModule,
  ],
  declarations: [
  ],
  exports: [
      MatCardModule,
      MatToolbarModule,
      MatDividerModule,
      MatFormFieldModule,
      MatDatepickerModule,
      MatSelectModule,
      HttpClientModule,
      ReactiveFormsModule,
      MatNativeDateModule,
      MatInputModule,
      MatSnackBarModule,
      MatButtonModule,
  ],
})
export class SharedModule { }