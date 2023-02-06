$("#submitBtn").click(function () {
    //if got 100% then it would be 50% of overall grade
    let assignments = parseInt($("#assignments").val()) * 0.5

    //if for 100% of points in area then it's 10% of overall grade
    let groupProj = parseInt($("#groupProject").val()) * 0.1

    let quizzes = parseInt($("#quizzes").val()) * 0.1

    let midterm = parseInt($("#midterm").val()) * 0.1

    let final = parseInt($("#final").val()) * 0.1

    let intex = parseInt($("#intex").val()) * 0.1

    //print out the total of all the percentages
    let finalGrade = (assignments + groupProj + quizzes + midterm + final + intex).toFixed(2)

    let letterGrade = ""

    //calculate the letter grade based on the overall percentage earned
    if (finalGrade >= 94) {
        letterGrade = 'A'
    } else if (finalGrade >= 90) {
        letterGrade = 'A-'
    } else if (finalGrade >= 87) {
        letterGrade = 'B+'
    } else if (finalGrade >= 84) {
        letterGrade = 'B'
    } else if (finalGrade >= 80) {
        letterGrade = 'B-'
    } else if (finalGrade >= 77) {
        letterGrade = 'C+'
    } else if (finalGrade >= 74) {
        letterGrade = 'C'
    } else if (finalGrade >= 70) {
        letterGrade = 'C-'
    } else if (finalGrade >= 67) {
        letterGrade = 'D+'
    } else if (finalGrade >= 64) {
        letterGrade = 'D'
    } else if (finalGrade >= 60) {
        letterGrade = 'D-'
    } else {
        letterGrade = 'E'
    }

    //add the results to the div on index.html
    //$("#results").text('You got a ' + finalGrade + "% which scored you a " + letterGrade + "!")
    alert('You got a ' + finalGrade + "% which scored you a " + letterGrade + "!")
})