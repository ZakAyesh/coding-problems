const { dirxml } = require("console");
const fs = require("fs");

const lines = fs
  .readFileSync("day12.txt", { encoding: "utf-8" })
  .split("\n")
  .filter((x) => x);

class Boat {
  constructor() {
    this.x = 0;
    this.y = 0;
    this.direction = 0;
  }

  move(char, number) {
    switch (char) {
      case "N":
        this.y += number;
        break;
      case "S":
        this.y -= number;
        break;
      case "E":
        this.x += number;
        break;
      case "W":
        this.x -= number;
        break;
      case "L":
        this.direction += (number / 90) % 4;
        break;
      case "R":
        this.direction -= (number / 90) % 4;
        break;
      case "F":
        switch (this.direction % 4) {
          case 0:
            this.x += number;
            break;
          case 1:
            this.y += number;
            break;
          case 2:
            this.x -= number;
            break;
            s;
          case 3:
            this.y -= number;
            break;
          case -1:
            this.y -= number;
            break;
          case -2:
            this.x -= number;
            break;
            s;
          case -3:
            this.y += number;
            break;
        }
    }
  }
  distance() {
    return Math.abs(this.x) + Math.abs(this.y);
  }
}

const boat = new Boat();

lines.forEach((line) => {
  const { groups } = /^(?<char>.)(?<number>\d+)$/.exec(line);
  boat.move(groups.char, parseInt(groups.number));
  console.log(boat.x, boat.y, boat.direction);
});

console.log(boat.distance());
