$("#formValidation").validate({
    rules: {
        FirstName: {
            minLength:2
        },
        email: {
            email:true
        }
    },
    messages: {
        FirstName: {
        required: "Required input",
        minlength: "Atleast 2 characters required"
        }
    }, 
    submitHandler: function (form) {
        form.submit();
    }
});