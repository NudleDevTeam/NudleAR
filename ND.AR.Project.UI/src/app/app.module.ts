import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MasterLayoutModule } from './master-layout/master-layout.module';
import { HomeComponent } from './home/home.component';
import { TopNavComponent } from './master-layout/top-nav/top-nav.component';

@NgModule({
  declarations: [AppComponent, HomeComponent, TopNavComponent],
  imports: [BrowserModule, AppRoutingModule,MasterLayoutModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
