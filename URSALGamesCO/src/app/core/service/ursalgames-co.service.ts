import { Injectable } from '@angular/core';

import { HttpClient, HttpErrorResponse } from '@angular/common/http';

import { catchError } from 'rxjs/operators';
import { Observable } from 'rxjs/internal/Observable';
import { throwError } from 'rxjs/internal/observable/throwError';
import { environment } from 'src/environments/environment';
import { Leaderboard } from '../model/leaderboard.model';
import { ResultsGamesPlayed } from '../model/results-games-played.model';
import { ResultGames } from '../model/result-games.model';

@Injectable({
  providedIn: 'root'
})
export class URSALGamesCOService {

  constructor(private http: HttpClient) { }

  getGames(): Observable<number[]> {
    return this.http.get<number[]>(`${environment.apiGames}GameResult/getListGames`)
      .pipe(catchError(this.handleError));
  }

  getGameResults(gameId: number): Observable<Leaderboard[]> {
    return this.http.get<Leaderboard[]>(`${environment.apiGames}GameResult/getResults/${gameId}`)
      .pipe(catchError(this.handleError));
  }

  getResultsByGamePlayed(): Observable<ResultsGamesPlayed[]> {
    return this.http.get<ResultsGamesPlayed[]>(`${environment.apiGames}GameResult/getResults/byGamePlayed`)
      .pipe(catchError(this.handleError));
  }

  putGameResults(resultGames: ResultGames[]): Observable<ResultGames[]> {
    return this.http.put<ResultGames[]>(`${environment.apiGames}GameResult`, resultGames)
      .pipe(catchError(this.handleError));
  }

  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      console.error('An error occurred:', error.error.message);
    } else {
      console.error(
        `Backend returned code ${error.status}, ` +
        `body was: ${error.error}`);
    }
    return throwError('An error occurred in the gaming API.');
  }
}
