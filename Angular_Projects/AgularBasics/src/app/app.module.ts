import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductsComponent } from '../products/products.component';
import { ClientListComponent } from '../client-list/client-list.component';
import { SearchComponent } from '../search/search.component';



@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    ClientListComponent,
    SearchComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
