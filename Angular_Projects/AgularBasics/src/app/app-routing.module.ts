import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientListComponent } from 'src/client-list/client-list.component';
import { ProductsComponent } from 'src/products/products.component';
import { SearchComponent } from 'src/search/search.component';


const routes: Routes = [
  {
    path: '', redirectTo: 'search', pathMatch: 'full'
  },
  {
    path: 'clientList', component: ClientListComponent
  },
  {
    path: 'search', component: SearchComponent
  },
  {
    path: 'products', component: ProductsComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
