function filterCategoriaExercicio() {

    let value = $("#procuraCategoriaExercicio").val();
    let bodyCategoriaExercicio = $("#bodyCatetoriaExercicioList");

    if (value === "") {
        location.href = "Index";
        return;
    }

    $.ajax({
        method: "POST",
        url: "/CategoriasExercicios/Filter",
        data: { "nome": value },
        success: data => {

            bodyCategoriaExercicio.children().remove();

            data.forEach(categoriaExercicio => {

                let td = $("<td/>").text(categoriaExercicio.nome);

                let a = $("<a/>").attr({
                    class: "btn-small light-blue darken-2",
                    href: `/CategoriasExercicios/Edit/${categoriaExercicio.categoriaExercicioId}`,
                });

                a.text("Atualizar");

                let a2 = $("<a/>").attr({
                    class: "btn-small red darken-2",
                    onclick: `ExibirModal(${categoriaExercicio.categoriaExercicioId}, '${categoriaExercicio.nome}')`
                });

                a2.text("Excluir");

                let td2 = $("<td/>");
                td2.append(a);
                td2.append("&nbsp;");
                td2.append(a2);
                
                let tr = $("<tr/>");
                tr.append(td);
                tr.append(td2);

                bodyCategoriaExercicio.append(tr);

            });
        }
    });

}

function filterObjetivo() {

    let obejtivoNome = $("#procuraObjetivoNome").val();
    let obejtivoDescricao = $("#procuraObjetivoDescricao").val();
    let bodyObejtivo = $("#bodyObjetivo");

    if (obejtivoNome === "" && obejtivoDescricao === "") {
        location.href = "Index";
        return;
    }

    $.ajax({
        method: "POST",
        url: "/Objetivos/Filter",
        data: {
            "nome": obejtivoNome,
            "descricao": obejtivoDescricao
        },
        success: data => {

            bodyObejtivo.children().remove();

            data.forEach(objetivo => {

                let column = $("<tr/>");
                let tdObjetivoNome = $("<td/>").text(objetivo.nome);
                let tdObjeitvoDescricao = $("<td/>").text(objetivo.descricao);
                let tdAcoes = $("<td/>");

                let a = $("<a/>").attr({
                    class: "btn-small light-blue darken-2",
                    href: `/Objetivos/Edit/${objetivo.ObjetivoId}`,
                });

                a.text("Atualizar");

                let a2 = $("<a/>").attr({
                    class: "btn-small red darken-2",
                    onclick: `ExibirModal(${objetivo.ObjetivoId}, '${objetivo.nome}')`
                });

                a2.text("Excluir");

                tdAcoes.append(a);
                tdAcoes.append("&nbsp;");
                tdAcoes.append(a2)

                column.append(tdObjetivoNome);
                column.append(tdObjeitvoDescricao);
                column.append(tdAcoes);

                bodyObejtivo.append(column);

            });

        }
    });
}

function filterExercicios(){

    let exercicioNome = $("#procuraNomeExercicio").val();
    let selectCategoriaExercicio = $("#selectCategoriaExercicio").val();
    let bodyExercicio = $("#bodyExercicio");

    if (exercicioNome === "" && selectCategoriaExercicio === "") {
        location.href = "Index";
        return;
    }

    $.ajax({
        method: "POST",
        url: "/Exercicios/Filter",
        data: {
            "nome": exercicioNome,
            "categoriaExercicioId": selectCategoriaExercicio
        },
        success: data => {

            bodyExercicio.children().remove();

            data.forEach(exercicio => {

                let column = $("<tr/>");
                let tdExercicioNome = $("<td/>").text(exercicio.nome);
                let tdCategoriaExercicio = $("<td/>").text(exercicio.categoriaExercicio.nome);
                let tdAcoes = $("<td/>");

                let a = $("<a/>").attr({
                    class: "btn-small light-blue darken-2",
                    href: `/Exercicios/Edit/${exercicio.ExercicioId}`,
                });

                a.text("Atualizar");

                let a2 = $("<a/>").attr({
                    class: "btn-small red darken-2",
                    onclick: `ExibirModal(${exercicio.ExercicioId}, '${exercicio.nome}')`
                });

                a2.text("Excluir");

                tdAcoes.append(a);
                tdAcoes.append("&nbsp;");
                tdAcoes.append(a2)

                column.append(tdExercicioNome);
                column.append(tdCategoriaExercicio);
                column.append(tdAcoes);

                bodyExercicio.append(column);

            });

        }
    });

}