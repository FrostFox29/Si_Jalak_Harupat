const scrollAnimation = document.querySelector('.scroll-animation');

window.addEventListener('scroll', () => {
  const { scrollTop, scrollHeight, clientHeight } = document.documentElement;
  const scrolled = (scrollTop / (scrollHeight - clientHeight)) * 100;
  
  scrollAnimation.style.transform = `translateX(-50%) translateY(-${scrolled}%)`;
  scrollAnimation.style.bottom = scrolled <= 10 ? '-50px' : '10px';
});