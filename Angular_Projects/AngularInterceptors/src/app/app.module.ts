import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { CommonInterceptor } from './common.interceptor';
import { ContentProjectionComponent } from './content-projection/content-projection.component';


@NgModule({
  declarations: [
    AppComponent,
    ContentProjectionComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    {provide:HTTP_INTERCEPTORS,useClass:CommonInterceptor,multi:true}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
