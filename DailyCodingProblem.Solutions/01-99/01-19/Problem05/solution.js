const cons = (a, b) => {
  const pair = (f) => {
    return f(a, b);
  }

  return pair;
}

const car = (pair) => {
  const f = (a, b) => a;

  return pair(f);
}

const cdr = (pair) => {
  const f = (a, b) => b;

  return pair(f);

}

console.log(car(cons(3, 4)) === 3)

console.log(cdr(cons(3, 4)) === 4)