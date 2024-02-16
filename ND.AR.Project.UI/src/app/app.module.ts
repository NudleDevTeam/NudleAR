import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MasterLayoutModule } from './master-layout/master-layout.module';
import { HomeComponent } from './home/home.component';
import { TopNavComponent } from './master-layout/top-nav/top-nav.component';
import { ContentAreaComponent } from './content-area/content-area.component';
import { LoginComponent } from './user-management/login/login.component';
import { NotFoundComponent } from './user-management/not-found/not-found.component';

@NgModule({
  declarations: [
    AppComponent, 
    HomeComponent,
    ContentAreaComponent ,
    TopNavComponent, 
    LoginComponent, 
    NotFoundComponent],
  imports: [BrowserModule, AppRoutingModule,],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
