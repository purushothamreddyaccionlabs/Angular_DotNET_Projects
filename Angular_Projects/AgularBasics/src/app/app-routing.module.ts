import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientListComponent } from 'src/client-list/client-list.component';
import { ProductsComponent } from 'src/products/products.component';
import { SearchComponent } from 'src/search/search.component';
import { AuthGuard } from './auth.guard';
import { PayCheckGuard } from './pay-check.guard';
import { UnsavedGuard } from './unsaved.guard';


const routes: Routes = [
  {
    path:'product/:id',component:ProductsComponent
  },
  {
    path:'product/:productId/photos/:photoId',component:ProductsComponent
  },
  {
    path:'clientList',component:ClientListComponent,
    canActivate:[AuthGuard]
  },
  {
    path:'search',component:SearchComponent,canDeactivate:[UnsavedGuard]
  },
  {
    path:'products',component:ProductsComponent
  },
  { 
    path: 'payments',
    canLoad:[PayCheckGuard],
    loadChildren: () => import('./payments/payments.module').then(m => m.PaymentsModule) 
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
