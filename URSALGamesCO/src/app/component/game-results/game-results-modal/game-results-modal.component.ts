
import { Component, Input, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { URSALGamesCOService } from 'src/app/core/service/ursalgames-co.service';
import { Leaderboard } from 'src/app/core/model/leaderboard.model';

@Component({
  selector: 'app-game-results-modal',
  templateUrl: './game-results-modal.component.html',
  styleUrls: ['./game-results-modal.component.scss']
})
export class GameResultsModalComponent implements OnInit {

  @Input() gameId: number;
  players: Leaderboard[];

  constructor(public activeModal: NgbActiveModal,
              private service: URSALGamesCOService) { }

  ngOnInit() {
    this.service.getGameResults(this.gameId).subscribe(
      players => {
        this.players = players;
      }
    );
  }

}
