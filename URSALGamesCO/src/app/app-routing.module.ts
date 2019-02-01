import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// Layout
import { DataPersistenceComponent } from './component/data-persistence/data-persistence.component';
import { GameResultsComponent } from './component/game-results/game-results.component';

const routes: Routes = [
    {
    path: '',
    children: [
       { path: 'data-persistence', component: DataPersistenceComponent },
       { path: 'game-results', component: GameResultsComponent }
    ]
  }]
;

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
