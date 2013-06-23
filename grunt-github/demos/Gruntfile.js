
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

    github: {
      options: {

      },

      repos: {
        options: {
          filters: {
            'type': 'public'
          }
        },
        src: '/orgs/assemble/repos',
        dest: 'assemble-public-repos.json'
      }
    }

  });

  // Load npm plugins to provide necessary tasks.
  grunt.loadNpmTasks('grunt-contrib-jshint');
  grunt.loadNpmTasks('grunt-github-api');

  // Default task.
  grunt.registerTask('default', ['github']);


};
