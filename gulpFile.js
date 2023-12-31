/// <binding AfterBuild='clean:js, miniimage, minjs, mincss' />
var gulp = require('gulp'),
    concat = require('gulp-concat'),
    cssmin = require('gulp-cssmin'),
    uglify = require('gulp-uglify'),
    del = require('del');
imagemin = require('gulp-imagemin');


var webrooFolder = 'wwwroot';
var paths = { webroot: "./" + webrooFolder + "/" };
paths.js = paths.webroot + "js/**/*.js";
paths.css = paths.webroot + "css/**/*.css";
paths.mylib = paths.webroot + "mylib";

paths.image = paths.webroot + "images/**/*";

gulp.task('clean', function () {
    return del.sync(paths.mylib + "/*");
});

gulp.task('minjs', function () {
    return gulp.src(paths.js)
        .pipe(concat('all.min.js'))
        .pipe(uglify())
        .pipe(gulp.dest(paths.mylib));
});

gulp.task('mincss', function () {
    return gulp.src(paths.css)
        .pipe(concat('style.css'))
        .pipe(cssmin())
        .pipe(gulp.dest(paths.mylib));
});

gulp.task('miniimage', function () {
    return gulp.src(paths.image)
        .pipe(imagemin())
        .pipe(gulp.dest(paths.webroot + 'images'));
});