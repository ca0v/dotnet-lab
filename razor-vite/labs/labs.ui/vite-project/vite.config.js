/**
 * The index.html must load files from /app/assets/ so modify the build output directory
 * to be ../wwwroot/app
 * And modify the root directory to /app
 * 
 */
export default {
    base: '/app/',
    build: {
      outDir: '../wwwroot/app',
    }
  }