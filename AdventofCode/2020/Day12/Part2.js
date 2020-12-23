const fs = require("fs");

const lines = fs
  .readFileSync("day12.txt", { encoding: "utf-8" })
  .split("\n")
  .filter((x) => x);

class Boat {
  constructor() {
    this.x = 0;
    this.y = 0;
  }
}

class Waypoint {
  constructor(boat) {
    this.x = 10;
    this.y = 1;
    this.boat = boat;
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
        {
          let oldX = this.x;
          let oldY = this.y;

          this.x = Math.round(
            oldX * Math.cos(number * (Math.PI / 180)) -
              oldY * Math.sin(number * (Math.PI / 180))
          );

          this.y = Math.round(
            oldY * Math.cos(number * (Math.PI / 180)) +
              oldX * Math.sin(number * (Math.PI / 180))
          );
        }
        break;
      case "R":
        {
          let oldX = this.x;
          let oldY = this.y;

          this.x = Math.round(
            oldX * Math.cos(number * ((-1 * Math.PI) / 180)) -
              oldY * Math.sin(number * ((-1 * Math.PI) / 180))
          );

          this.y = Math.round(
            oldY * Math.cos(number * ((-1 * Math.PI) / 180)) +
              oldX * Math.sin(number * ((-1 * Math.PI) / 180))
          );
        }
        break;
      case "F":
        {
          this.boat.x += number * this.x;
          this.boat.y += number * this.y;
        }
        break;
    }
  }
  distance() {
    return Math.abs(this.boat.x) + Math.abs(this.boat.y);
  }
}

const boat = new Boat();
const wayPoint = new Waypoint(boat);

lines.forEach((line) => {
  const { groups } = /^(?<char>.)(?<number>\d+)$/.exec(line);
  wayPoint.move(groups.char, parseInt(groups.number));
  console.log("Waypoint location: ", wayPoint.x, wayPoint.y);
  console.log("Boat location: ", wayPoint.boat.x, wayPoint.boat.y);
});

console.log(wayPoint.distance());
