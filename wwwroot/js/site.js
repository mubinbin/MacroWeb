﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function showModal(url, title)
{   
    $.ajax({
        type:"GET",
        url: url,
        success: function(response){
            // console.log(response);
            $("#form-modal .modal-title").html(title);
            $("#form-modal .modal-body").html(response);
            $("#form-modal").modal();
        },
        error: function(err){
            console.log(err);
        }
    });
}

mespost = form =>
{
    $.ajax({
        type:"POST",
        url: form.action,
        data: new FormData(form),
        contentType: false,
        processData: false,
        success: function(response){
            console.log(response.renderPage);
            if(!response.successful)
            {
                $("#form-modal .modal-body").html(response.renderPage);

            }else{
                $("#show-message").html(response.renderPage);
                $('#form-modal .modal-body').html('');
                $('#form-modal .modal-title').html('');
                $('#form-modal').modal('hide');
            }
        },
        error: function(err){
            console.log(err);
        }
    });

    return false;
}

del = (form, title) =>
{
    if(confirm(`Are you sure to delete this ${title}?`))
    {
        // console.log(form);
        $.ajax({
            type: "POST",
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function(response){
                // console.log(response);
                $("#show-message").html(response.renderPage);
            },
            error: function(err){
                console.log(err);
            }
        });
    }
    return false;
}

follow = (form) =>
{
    // console.log(form);
    $.ajax({
        type: "POST",
        url: form.action,
        data: new FormData(form),
        contentType: false,
        processData: false,
        success: function(response){
            // console.log(response);
            $("#form-modal .modal-body").html(response);
        },
        error: function(err){
            console.log(err);
        }
    });
    return false;
}

likeorunlike = (url) =>
{
    // console.log(url)
    $.ajax({
        type:"GET",
        url: url,
        success: function(response){
            // console.log(response);
            // console.log(response.renderPage);
            $("#show-message").html(response.renderPage);
        },
        error: function(err){
            console.log(err);
        }
    });
}

editprofile = (url) =>
{
    // console.log(url)
    $.ajax({
        type:"GET",
        url: url,
        success: function(response){
            // console.log(response);
            // console.log(response.renderPage);
            $("#edit-profile").html(response);
        },
        error: function(err){
            console.log(err);
        }
    });
}