import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// Layout
import { DataPersistenceComponent } from './component/data-persistence/data-persistence.component';
import { GameResultsComponent } from './component/game-results/game-results.component';
import { TopGamesPlayedComponent } from './component/top-games-played/top-games-played.component';

const routes: Routes = [
    {
    path: '',
    children: [
      { path: 'game-results', component: GameResultsComponent },
      { path: 'top-players-played', component: TopGamesPlayedComponent },
      { path: 'data-persistence', component: DataPersistenceComponent },
    ]
  }]
;

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
