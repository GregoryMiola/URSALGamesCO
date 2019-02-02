import { Component, OnInit } from '@angular/core';
import { URSALGamesCOService } from '../../core/service/ursalgames-co.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { GameResultsModalComponent } from './game-results-modal/game-results-modal.component';

@Component({
  selector: 'app-game-results',
  templateUrl: './game-results.component.html',
  styleUrls: ['./game-results.component.scss']
})
export class GameResultsComponent implements OnInit {

  games: number[];

  constructor(private modalService: NgbModal, private service: URSALGamesCOService) { }

  ngOnInit() {
    this.service.getGames().subscribe(
      games => {
        this.games = games;
      }
    );
  }

  open(game: number) {
    const modalRef = this.modalService.open(GameResultsModalComponent);
    modalRef.componentInstance.gameId = game;
  }
}
