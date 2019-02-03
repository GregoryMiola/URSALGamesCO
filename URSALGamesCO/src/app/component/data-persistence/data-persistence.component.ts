import { Component, OnInit } from '@angular/core';
import { ResultGames } from 'src/app/core/model/result-games.model';
import { URSALGamesCOService } from 'src/app/core/service/ursalgames-co.service';
import { reduce } from 'rxjs/operators';

@Component({
  selector: 'app-data-persistence',
  templateUrl: './data-persistence.component.html',
  styleUrls: ['./data-persistence.component.scss']
})
export class DataPersistenceComponent implements OnInit {

  constructor(private service: URSALGamesCOService) { }

  ngOnInit() {
    this.service.putGameResults(this.prepareDataPersistense()).subscribe(
      (success) => {
      },
      (error) => {
      }
    );
  }

  prepareDataPersistense(): ResultGames[] {
    const results: ResultGames[] = [];
    let randPossibilities = Math.floor(Math.random() * 50) + 1;
    const datetimeNow = new Date();
    while (randPossibilities >= 1) {
      results.push(new ResultGames (
          Math.floor(Math.random() * 50) + 1
           , Math.floor(Math.random() * 20) + 1
           , (Math.floor(Math.random() * 100) + 1) * (Math.floor(Math.random() * 2) === 1 ? 1 : -1)
           , this.randomDate()
      ));

      randPossibilities--;
    }

    return results;
  }

  randomDate() {
    const date = new Date();
    date.setHours((Math.floor(Math.random() * 23) + 0) * (-1));
    date.setMinutes(Math.floor(Math.random() * 60) + 0);
    date.setSeconds(Math.floor(Math.random() * 60) + 0);
    return date;
  }
}
