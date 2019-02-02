import { Component, OnInit } from '@angular/core';
import { URSALGamesCOService } from 'src/app/core/service/ursalgames-co.service';
import { ResultsGamesPlayed } from 'src/app/core/model/results-games-played.model';

@Component({
  selector: 'app-top-games-played',
  templateUrl: './top-games-played.component.html',
  styleUrls: ['./top-games-played.component.scss']
})
export class TopGamesPlayedComponent implements OnInit {

  players: ResultsGamesPlayed[];

  constructor(private service: URSALGamesCOService) { }

  ngOnInit() {
    this.service.getResultsByGamePlayed().subscribe(
      players => {
        this.players = players;
      }
    );
  }

}
