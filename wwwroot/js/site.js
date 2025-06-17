$(document).ready(function () {
  $('#Emprestimos').DataTable({
    language: {
      "emptyTable": "Nenhum registro encontrado na tabela",
      "info": "Mostrar _START_ até _END_ de _TOTAL_ registros",
      "infoEmpty": "Mostrar 0 até 0 de 0 Registros",
      "infoFiltered": "(Filtrar de _MAX_ total registros)",
      "infoPostFix": "",
      "infoThousands": ".",
      "lengthMenu": "Mostrar _MENU_ registros por pagina",
      "loadingRecords": "Carregando...",
      "processing": "Processando...",
      "zeroRecords": "Nenhum registro encontrado",
      "search": "Pesquisar",
      "paginate": {
        "next": "Proximo",
        "previous": "Anterior",
        "first": "Primeiro",
        "last": "Ultimo",
      },
     "aria": {
        "SortAscending": ": Ordenar colunas de forma ascendente",
        "SortDescending": ": Ordenar colunas de forma descendente",
      },
    },
  });

  setTimeout(function () {
    $(".alert").fadeOut("slow", function () {
      $(this).alert("close");
    });
  }, 4000);
});