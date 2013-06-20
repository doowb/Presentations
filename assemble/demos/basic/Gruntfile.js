
module.exports = function(grunt) {

  'use strict';


  // Project configuration.
  grunt.initConfig({

    // Project metadata
    pkg: grunt.file.readJSON('package.json'),


    jshint: {
      all: [
        'Gruntfile.js'
      ],
      options: {
        jshintrc: '.jshintrc'
      }
    },

    assemble: {
      options: {
        assets: 'staging/assets',
        flatten: true,
        ext: '.html',
        data:  [
          'src/data/**/*.{json,yml}'
        ]
      },
      demo: {
        options: {
          layout: 'src/templates/layouts/layout.hbs',
          partials: 'src/templates/partials/**/*.hbs'
        },
        files: [
          { expand: true, cwd: 'src/templates/pages', src: ['**/*.hbs'], dest: 'staging/' }
        ]
      }
    },

    copy: {
      'prod-pages': {
        options: {
          processContent: function(content) {
            return content.replace('{%', '{{').replace('%}', '}}');
          }
        },
        files: [
          { expand: true, cwd: 'staging', dest: 'app/public/', src: ['./**/*.html'] }
        ]
      },
      'prod-assets': {
        files: [
          { expand: true, cwd: 'staging/assets', dest: 'app/public/assets/', src: ['./**/*.*'] }
        ]
      }
    },

    // Before generating new files, clean out files from previous build.
    clean: {
      staging: {
        src: ['staging/**/*.*']
      },
      prod: {
        src: ['app/**/*.*']
      }
    },

    watch: {
      project: {
        files: [
          'src/**/*.*'
        ],
        tasks: ['clean:staging', 'assemble']
      }
    }

  });

  // Load npm plugins to provide necessary tasks.
  grunt.loadNpmTasks('grunt-contrib-clean');
  grunt.loadNpmTasks('grunt-contrib-copy');
  grunt.loadNpmTasks('grunt-contrib-jshint');
  grunt.loadNpmTasks('grunt-contrib-watch');
  grunt.loadNpmTasks('assemble');

  // Load local tasks.
  grunt.loadTasks('tasks');

  // Default task.
  grunt.registerTask('default', ['clean:staging', 'assemble']);

  // Tests to be run.
  //grunt.registerTask('test', ['assemble:less']);

  // Upstage application.
  grunt.registerTask('app', [
    'clean:prod',
    'default',
    'copy'
  ]);

};
