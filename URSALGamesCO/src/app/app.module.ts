import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DataPersistenceComponent } from './component/data-persistence/data-persistence.component';
import { GameResultsComponent } from './component/game-results/game-results.component';

@NgModule({
  declarations: [
    AppComponent,
    DataPersistenceComponent,
    GameResultsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
