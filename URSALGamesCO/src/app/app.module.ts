import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import {NgbModule} from '@ng-bootstrap/ng-bootstrap';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DataPersistenceComponent } from './component/data-persistence/data-persistence.component';
import { GameResultsComponent } from './component/game-results/game-results.component';
import { GameResultsModalComponent } from './component/game-results/game-results-modal/game-results-modal.component';
import { TopGamesPlayedComponent } from './component/top-games-played/top-games-played.component';

@NgModule({
  declarations: [
    AppComponent,
    DataPersistenceComponent,
    GameResultsComponent,
    GameResultsModalComponent,
    TopGamesPlayedComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    NgbModule,
  ],
  entryComponents: [
    GameResultsModalComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
