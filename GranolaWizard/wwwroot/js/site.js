(function () {
    $(document).ready(function () {
        // Wire up the Add button to send the new item to the server
        $('#add-item-button').on('click', addItem);
        // Enter key can also be used for Add
        $('#add-item-title').on('keypress', function (e) {
            var key = e.which;
            if (key === 13) { $('#add-item-button').click(); return false; }
        }).focus();

        // Wire up all of the checkboxes to run markCompleted()
        $('.done-checkbox').on('click', function (e) {
            markCompleted(e.target);
        });
    });    function addItem() {
        var $errorMsg = $('#add-item-error');
        var $title = $('#add-item-title');

        $errorMsg.hide();
        $.post('/Todo/AddItem', { title: $title.val() }, function () {
            window.location = '/Todo';
        })
            .fail(function (data) {
                if (data && data.responseJSON) {
                    var firstError = data.responseJSON[Object.keys(data.responseJSON)[0]];
                    $errorMsg.text(firstError).show();
                }
            });
    }

    function markCompleted(checkbox) {
        checkbox.disabled = true;
        $.post('/Todo/MarkDone', { id: checkbox.name }, function () {
            var row = checkbox.parentElement.parentElement;
            $(row).addClass('done');
        });
    }    
})();
