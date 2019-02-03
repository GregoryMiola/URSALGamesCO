export class ResultGames {
    gameId: number;
    playerId: number;
    win: number;
    timestamp: Date;

    constructor(gameId: number, playerId: number, win: number, timestamp: Date) {
        this.gameId = gameId;
        this.playerId = playerId;
        this.win = win;
        this.timestamp = timestamp;
    }
}
