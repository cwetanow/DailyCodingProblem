const scheduler = (f, n) => {
  setTimeout(f, n);
}

scheduler(() => console.log('done'), 2500);